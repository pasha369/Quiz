using QuizMaker.Models;

namespace Quiz.Models
{
    public class ScoreModel:ObservableObject
    {
        private string _type = string.Empty;
        private int _number = 0;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                OnPropertyChanged("Number");
            }

        }
    }
}