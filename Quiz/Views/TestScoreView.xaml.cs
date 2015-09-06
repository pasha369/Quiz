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
    /// Interaction logic for TestScoreView.xaml
    /// </summary>
    public partial class TestScoreView
    {
        private TestScoreViewModel viewModel;
        public TestScoreView(Test test, List<QuestionModel> questions)
        {
            InitializeComponent();
            viewModel = new TestScoreViewModel(test, questions);
            this.DataContext = viewModel;


        }
    }
}
