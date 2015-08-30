using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using Quiz.QuizServiceReference;
using QuizMaker.Models.DatabaseEntity;
using QuizMaker.ViewModels;
using Path = System.IO.Path;
using RadioButton = System.Windows.Controls.RadioButton;
using RichTextBox = System.Windows.Controls.RichTextBox;

namespace QuizMaker.Views
{
    /// <summary>
    /// Interaction logic for TestEdit.xaml
    /// </summary>
    public partial class TestEdit 
    {

        public TestEdit(Tests test)
        {
            TestEditViewModel viewModel = new TestEditViewModel(test);
            this.DataContext = viewModel;
            InitializeComponent();

        }

        private void btnAddChoice_Click(object sender, RoutedEventArgs e)
        {
            var rBtn = new RadioButton();
            rBtn.GroupName = "Variants";

            var text = new RichTextBox();
            text.Width = 280;

            rBtn.Content = text;
            rBtn.Margin = new Thickness(5);
            
        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)
        {
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
                    img.Save(ms,System.Drawing.Imaging.ImageFormat.Gif);
                    
                    imgData = ms.ToArray();
                }

                var path = fileTransfer.UploadFile(imgData, name);
                
            }
        }
    }
}
