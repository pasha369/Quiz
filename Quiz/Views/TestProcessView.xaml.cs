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
using Quiz.ViewModels;

namespace Quiz.Views
{
    /// <summary>
    /// Interaction logic for TestProcessView.xaml
    /// </summary>
    public partial class TestProcessView 
    {
        public TestProcessView()
        {
            var viewModel = new TestProcessViewModel();
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
