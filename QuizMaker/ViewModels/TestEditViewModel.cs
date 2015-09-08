using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Input;
using Quiz.QuizServiceReference;
using QuizMaker.Commands;
using QuizMaker.Models;
using QuizMaker.Models.DatabaseEntity;
using FileDialog = Microsoft.Win32.FileDialog;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace QuizMaker.ViewModels
{
    /// <summary>
    /// View model for view TestEdit. 
    /// Implement logic for create, save and update test
    /// </summary>
    public class TestEditViewModel : ObservableObject
    {
        private VariantModel _currentVariant;
        private QuestionModel _currentQuestion;

        private ObservableCollection<QuestionModel> _testQuestions;
        private Tests _currentTest;

        private ICommand _addMultipleQ;
        private ICommand _addSingleQ;

        private ICommand _saveQuestionCmd;
        private ICommand _delQuestionCmd;

        private ICommand _saveTestCmd;

        private ICommand _addVariantCmd;
        private ICommand _addVariantImgCmd;
        private ICommand _delVariantCmd;

        public TestEditViewModel(Tests test)
        {
            _currentTest = test;
            _currentQuestion = new QuestionModel();
            _testQuestions = new ObservableCollection<QuestionModel>();

        }

        public ObservableCollection<QuestionModel> TestQuestions
        {
            get { return _testQuestions; }
            set
            {
                if (value != null)
                {
                    _testQuestions = value;
                    OnPropertyChanged("TestQuestions");
                }
            }
        }
        public QuestionModel CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                if (value != null)
                {
                    _currentQuestion = value;
                    OnPropertyChanged("CurrentQuestion");
                }
            }
        }
        public VariantModel CurrentVariant
        {
            get { return _currentVariant; }
            set
            {
                _currentVariant = value;
                OnPropertyChanged("CurrentVariant");
            }
        }

        public ICommand AddMultipleQ
        {
            get
            {
                if(_addMultipleQ == null)
                {
                    _addMultipleQ = new RelayCommand(param => AddMultipleQuestion());
                }
                return _addMultipleQ;
            }
        }
        public ICommand AddSingleQ
        {
            get
            {
                if (_addSingleQ == null)
                {
                    _addSingleQ = new RelayCommand(param => AddSingleQuestion());
                }
                return _addSingleQ;
            }
        }

        public ICommand DelQuestionCmd
        {
            get
            {
                if (_delQuestionCmd == null)
                {
                    _delQuestionCmd = new RelayCommand(param => DeleteQuestion());
                }
                return _delQuestionCmd;
            }
        }
        public ICommand SaveQuestionCmd
        {
            get
            {
                if (_saveQuestionCmd == null)
                {
                    _saveQuestionCmd = new RelayCommand(param => SaveQuestion(),
                                                        param => (CurrentQuestion != null));
                }
                return _saveQuestionCmd;
            }
        }

        public ICommand SaveTestCmd
        {
            get
            {
                if (_saveTestCmd == null)
                {
                    return _saveTestCmd = new RelayCommand(param => SaveTest());
                }
                return _saveTestCmd;
            }
        }

        public ICommand AddVariantCmd
        {
            get
            {
                if (_addVariantCmd == null)
                {
                    return _addVariantCmd = new RelayCommand(param => AddVariant());
                }
                return _addVariantCmd;
            }
        }
        public ICommand AddVariantImgCmd
        {
            get
            {
                if (_addVariantImgCmd == null)
                {
                    return _addVariantImgCmd = new RelayCommand(param => AddVariantImage());
                }
                return _addVariantImgCmd;
            }
        }
        public ICommand DelVariantCmd
        {
            get
            {
                if (_delVariantCmd == null)
                {
                    _delVariantCmd = new RelayCommand(parm => DeleteVariant());
                }
                return _delVariantCmd;
            }
        }


        /// <summary>
        /// Add question with multiple correct variants
        /// </summary>
        private void AddMultipleQuestion()
        {
            CurrentQuestion = new QuestionModel();
            CurrentQuestion.Type = "Multiple";
        }

        /// <summary>
        /// Add question with single correct variant
        /// </summary>
        private void AddSingleQuestion()
        {
            CurrentQuestion = new QuestionModel();
            CurrentQuestion.Type = "Single";
        }

        /// <summary>
        /// Add image to selected variant
        /// </summary>
        private void AddVariantImage()
        {
            var variant = CurrentQuestion.Variants
                .FirstOrDefault(v => v == CurrentVariant);
            if(variant != null)
            {
                variant.ImageUri = UploadImg();
            }
                
        }
        /// <summary>
        /// Add new variant to current question variants
        /// </summary>
        private void AddVariant()
        {
            CurrentQuestion.Variants.Add(new VariantModel());
        }

        /// <summary>
        /// Delete selected variant
        /// </summary>
        private void DeleteVariant()
        {
            if(CurrentVariant != null)
            {
                CurrentQuestion.Variants.Remove(CurrentVariant);
            }
        }

        /// <summary>
        /// Save test to database
        /// </summary>
        private void SaveTest()
        {
            try
            {
                using (var context = new QuizDBEntities())
                {
                    var questionIdx = context.Questions.ToList().Select(t => t.id).Max() + 1;
                    var answerIdx = context.Answers.ToList().Select(t => t.id).Max() + 1;
                    var variantIdx = context.Variants.ToList().Select(t => t.id).Max() + 1;
                    context.Tests.Add(_currentTest);

                    foreach (var itemQuestion in _testQuestions)
                    {
                        var question = new Questions();
                        question.id = questionIdx++;
                        question.testId = this._currentTest.id;
                        question.question = itemQuestion.QuestionText;
                        question.question_type = itemQuestion.Type;
                        //TODO: list variants

                        foreach (var itemVariant in itemQuestion.Variants)
                        {
                            var variant = new Variants();
                            variant.id = variantIdx++;
                            variant.variant = itemVariant.VariantText;
                            variant.imgPath = itemVariant.ImageUri;
                            //variant.variant_type = itemVariant.Type;
                            variant.questionId = question.id;
                            if (itemVariant.IsCorrect == true)
                            {
                                var answer = new Answers();
                                answer.id = answerIdx++;
                                answer.questionId = question.id;
                                answer.variantId = variant.id;
                                context.Answers.Add(answer);
                            }
                            question.Variants.Add(variant);
                        }
                        //
                        context.Questions.Add(question);
                    }
                    context.SaveChanges();
                }

                // Your code...
                // Could also be before try if you know the exception occurs in SaveChanges


            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    var error = String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        error += string.Format("\n- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        /// <summary>
        /// Delete selected question
        /// </summary>
        private void DeleteQuestion()
        {
            if (TestQuestions.Contains(CurrentQuestion))
            {
                TestQuestions.Remove(CurrentQuestion);
            }
        }
        
        /// <summary>
        /// Save current question
        /// </summary>
        private void SaveQuestion()
        {
            if (TestQuestions.Contains(CurrentQuestion))
            {
                CurrentQuestion = new QuestionModel();
            }
            else
            {
                TestQuestions.Add(CurrentQuestion);
                CurrentQuestion = new QuestionModel();
            }
        }
        /// <summary>
        /// Upload image to WCF service
        /// </summary>
        /// <returns></returns>
        private string UploadImg()
        {
            string path = string.Empty;

            FileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var filename = openFileDialog.FileName;

                var name = openFileDialog.SafeFileName;
                IFileTransfer fileTransfer = new FileTransferClient();
                byte[] imgData;

                using (var ms = new MemoryStream())
                {
                    Image img = Image.FromFile(filename);
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                    imgData = ms.ToArray();
                }

                path = fileTransfer.UploadFile(imgData, name);

            }
            return path;
        }
    }
}
