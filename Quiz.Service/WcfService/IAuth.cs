using System.ServiceModel;

namespace Quiz.Service.WcfService
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
