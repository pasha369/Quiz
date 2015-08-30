using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.Models.Abstract;
using QuizMaker.Models.DatabaseEntity;

namespace QuizMaker.Models
{
    /// <summary>
    /// Implement question model for work with questions
    /// </summary>
    public class QuestionModel : ObservableObject, IQuestionModel
    {
        private int _questionId;
        private string _questionText;
        private ObservableCollection<VariantModel> _variants;
        private int _answerId;
        private string _taskStatus;

        public string TaskStatus
        {
            set { _taskStatus = value;
            OnPropertyChanged("TaskStatus");
            }
            get { return _taskStatus; }
        }

        public QuestionModel()
        {
            TaskStatus = "Closed";
            _variants = new ObservableCollection<VariantModel>();
        }

        public int QuestionId
        {
            get { return _questionId; }
            set
            {
                _questionId = value;
                OnPropertyChanged("QuestionId");
            }
        }

        public string QuestionText
        {
            get { return _questionText; }
            set
            {
                _questionText = value;
                OnPropertyChanged("QuestionText");
            }
        }
        public ObservableCollection<VariantModel> Variants
        {
            get
            {
                return _variants;
            }
            set { 
                _variants = value;
                OnPropertyChanged("Variants");
            }
        }
        public int AnswerId
        {
            get { return _answerId; }
            set { 
                _answerId = value;
                OnPropertyChanged("AnswerId");
            }
        }
    }
}