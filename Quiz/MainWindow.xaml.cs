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
using Quiz.QuizServiceReference;
using Quiz.Views;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var view = new TestProcessView();
            view.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AuthClient client = new AuthClient();
            ITestOperation testClient = new TestOperationClient();
            if(client.SignIn(txtLogin.Text, txtPassword.Text))
            {
                txtResult.Text = "Success " + testClient.GetTest().Name;
                
            }
            else
            {
                txtResult.Text = "Fail";
            }
        }
    }
}
