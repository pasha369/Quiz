using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizMaker.Models
{
    /// <summary>
    /// Implement question model for work with questions
    /// </summary>
    public class QuestionModel : ObservableObject
    {
        private int _questionId;
        private string _questionText;
        private ObservableCollection<VariantModel> _variants;
        private int _answerId;
        private string _type;
        public QuestionModel()
        {
            _variants = new ObservableCollection<VariantModel>();
        }

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
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
            set
            {
                _variants = value;
                OnPropertyChanged("Variants");
            }
        }
        public int AnswerId
        {
            get { return _answerId; }
            set
            {
                _answerId = value;
                OnPropertyChanged("AnswerId");
            }
        }
    }
}