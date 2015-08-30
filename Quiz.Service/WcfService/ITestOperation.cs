using System.ServiceModel;
using QuizMaker.WcfService.Model;

namespace Quiz.Service.WcfService
{
    [ServiceContract]
    interface ITestOperation
    {
        [OperationContract]
        Test GetTest();
    }

}
