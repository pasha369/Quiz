using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace QuizMaker.WcfService
{
    [ServiceContract]
    interface IAuth
    {
        [OperationContract]
        bool SignIn(string login, string password);
        [OperationContract]
        void SignUp(string name, string last_name, string login, string password);
    }
}
