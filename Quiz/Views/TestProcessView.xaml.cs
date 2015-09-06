using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Quiz.QuizServiceReference;
using Quiz.ViewModels;
using QuizMaker.Models;

namespace Quiz.Views
{
    /// <summary>
    /// Interaction logic for TestProcessView.xaml
    /// </summary>
    public partial class TestProcessView 
    {
        private TestProcessViewModel viewModel;

        public TestProcessView(Test selectedTest)
        {
            viewModel = new TestProcessViewModel(selectedTest);

            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            var view = new TestScoreView(viewModel.CurrentTest, viewModel.Questions);
            view.Show();

            this.Close();
        }
    }
}
