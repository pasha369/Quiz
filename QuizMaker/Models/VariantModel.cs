namespace QuizMaker.Models
{
    /// <summary>
    /// Implement variant model
    /// </summary>
    public class VariantModel : ObservableObject
    {
        private int _variantId;
        private string _variantText;
        private string _imageUri;
        private bool _isCorrect;
        private string _type;

        public string ImageUri
        {
            get { return _imageUri; }
            set
            {
                _imageUri = value;
                OnPropertyChanged("ImageUri");
            }
        }

        public int VariantId
        {
            get { return _variantId; }
            set
            {
                _variantId = value;
                OnPropertyChanged("VariantId");
            }
        }

        public string VariantText
        {
            get { return _variantText; }
            set
            {
                _variantText = value;
                OnPropertyChanged("VariantText");
            }
        }
        public bool IsCorrect
        {
            get { return _isCorrect; }
            set
            {
                _isCorrect = value;
                OnPropertyChanged("IsCorrect");
            }
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
    }
}