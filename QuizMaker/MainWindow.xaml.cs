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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using QuizMaker.Models.DatabaseEntity;
using QuizMaker.ViewModels;
using QuizMaker.Views;

namespace QuizMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow :MetroWindow
    {
        public MainWindow()
        {
            var viewModel = new TestViewModel();
            InitializeComponent();
            this.DataContext = viewModel;



        }

        private async void btnAddTest_Click(object sender, RoutedEventArgs e)
        {
            int id;
            string name = await this.ShowInputAsync("Name", "Please, enter test name", null);
            if(name != null)
            {
                using (var context = new QuizDBEntities())
                {
                    id = context.Tests.ToList().Select(t => t.id).Max() + 1;
                }
                Tests test = new Tests();
                test.id = id;
                test.name = name;
                var view = new TestEdit(test);
                this.Close();
                view.Show();
            }
        }
    }
}
