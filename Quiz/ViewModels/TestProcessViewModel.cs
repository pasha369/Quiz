using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Quiz.QuizServiceReference;
using QuizMaker.Commands;
using QuizMaker.Models;

namespace Quiz.ViewModels
{
    class TestProcessViewModel : ObservableObject
    {
        private QuestionModel _currentQuestion;
        private List<QuestionModel> _questions;
        private int _idx;

        private ICommand _nextCmd;
        private ICommand _prevCmd;

        public TestProcessViewModel()
        {
            _questions = new List<QuestionModel>();
            TestOperationClient client = new TestOperationClient();
            InitQuestions(client.GetTest().Questions.ToList());
            LoadQuestion(_idx);
        }
        private void InitQuestions(List<Question> questions)
        {
            foreach (var questionItem in questions)
            {
                QuestionModel questionModel = new QuestionModel();
                questionModel.QuestionText = questionItem.QuestionText;
                foreach (var variantItem in questionItem.Variants)
                {
                    var variant = new VariantModel();
                    if(variantItem.Type == "Image")
                    {
                        FileTransferClient fileTransfer = new FileTransferClient();

                        TransferedImage img = fileTransfer.DownloadImage(variantItem.ImageUri);
                        var path = SaveImage(img.data, img.Filename);
                        variant.ImageUri = path;
                        variant.Type = variantItem.Type;
                    }
                    else
                    {
                        variant.VariantText = variantItem.VariantText;                    
                    }
                    questionModel.Variants.Add(variant);
                }
                _questions.Add(questionModel);
            }
        }

        public ICommand PrevCmd
        {
            get
            {
                if (_prevCmd == null)
                {
                    _prevCmd = new RelayCommand(param => LoadPrevQuestion());
                }
                return _prevCmd;
            }
        }


        public ICommand NextCmd
        {
            get
            {
                if (_nextCmd == null)
                {
                    _nextCmd = new RelayCommand(param => LoadNextQuestion());
                }
                return _nextCmd;
            }
        }

        private void LoadPrevQuestion()
        {
            if (_idx > 0)
            {
                _idx--;
                LoadQuestion(_idx);
            }
        }

        private void LoadNextQuestion()
        {
            if (_idx < _questions.Count-1)
            {
                _idx++;
                LoadQuestion(_idx);
            }
        }

        public QuestionModel CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                _currentQuestion = value;
                OnPropertyChanged("CurrentQuestion");
            }
        }

        private void LoadQuestion(int idx)
        {
            CurrentQuestion = _questions[idx];
        }
        private  string SaveImage(byte[] data, string filename)
        {

            using (var ms = new MemoryStream(data))
            {
                try
                {
                    Image img = Image.FromStream(ms);
                    string dir_path =
                        Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                    var path = String.Format("{0}\\Images\\{1}",
                                             dir_path, filename);
                    img.Save(path);
                    return path;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                return "";
            }
        }
    }
}
