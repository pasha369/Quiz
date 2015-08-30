using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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

        private QuestionModel _currentQuestion;

        private ObservableCollection<QuestionModel> _testQuestions;
        private Tests _currentTest;

        private ICommand _saveQuestionCmd;
        private ICommand _saveTestCmd;
        private ICommand _addVariantCmd;
        private ICommand _addVariantImgCmd;

        public TestEditViewModel(Tests test)
        {
            _currentTest = test;
            _currentQuestion = new QuestionModel();
            _testQuestions = new ObservableCollection<QuestionModel>();

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

        private void AddVariantImage()
        {
            CurrentQuestion.Variants[0].Type = "Image";
            CurrentQuestion.Variants[0].ImageUri = UploadImg();
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



        private void AddVariant()
        {
            CurrentQuestion.Variants.Add(new VariantModel());
        }

        private void SaveTest()
        {
            try
            {
            using (var context = new QuizDBEntities())
            {
                var questionIdx = context.Questions.ToList().Select(t => t.id).Max() + 1;
                var variantIdx = context.Variants.ToList().Select(t => t.id).Max() + 1;
                context.Tests.Add(_currentTest);
                
                foreach (var itemQuestion in _testQuestions)
                {
                    var question = new Questions();
                    question.id = questionIdx++;
                    question.testId = this._currentTest.id;
                    question.question = itemQuestion.QuestionText;
                    //TODO: list variants

                    foreach (var itemVariant in itemQuestion.Variants)
                    {
                        var variant = new Variants();
                        variant.id = variantIdx++;
                        variant.variant = itemVariant.VariantText;
                        variant.imgPath = itemVariant.ImageUri;
                        variant.variant_type = itemVariant.Type;
                        variant.questionId = question.id;
                        if (itemVariant.IsCorrect == true)
                        {
                            var answer = new Answers();
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


        private void SaveQuestion()
        {
            TestQuestions.Add(CurrentQuestion);
            CurrentQuestion = new QuestionModel();
        }

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
