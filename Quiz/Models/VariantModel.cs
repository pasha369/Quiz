using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
        private BitmapImage _imgSrc;
        private string _isMultiple;

        public string ImageUri
        {
            get { return _imageUri; }
            set
            {
                // Load image from service
                // to current client.
                _imageUri = value;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(_imageUri);
                bitmapImage.EndInit();
                _imgSrc = bitmapImage;
                _imageUri = value;
                OnPropertyChanged("ImageUri");
            }
        }

        public ImageSource ImageSrc
        {
            get { return _imgSrc; }
            set
            {
                if (_imgSrc != value)
                {
                    _imgSrc = value as BitmapImage;
                    OnPropertyChanged("ImageSrc");
                }
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

        public string IsMultiple
        {
            get { return _isMultiple; }
            set
            {
                _isMultiple = value;
                OnPropertyChanged("IsMultiple");
            }
        }
    }
}