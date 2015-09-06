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

namespace Quiz.Views
{
    /// <summary>
    /// Interaction logic for AuthView.xaml
    /// </summary>
    public partial class AuthView 
    {
        public AuthView()
        {
            InitializeComponent();

        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            AuthClient client = new AuthClient();
            ITestOperation testClient = new TestOperationClient();
            if (client.SignIn(txtLogin.Text, txtPassword.Text))
            {
                var view = new UserProfileView();
                view.Show();

                this.Close();
            }
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
