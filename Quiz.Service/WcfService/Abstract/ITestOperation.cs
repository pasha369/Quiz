using System.Collections.Generic;
using System.ServiceModel;
using Quiz.Service.WcfService.Model;

namespace Quiz.Service.WcfService.Abstract
{
    [ServiceContract]
    interface ITestOperation
    {
        [OperationContract]
        Test GetTest(int testId);

        [OperationContract]
        List<Answer> GetAnswers(int questionId);

        [OperationContract]
        List<Test> GetPassedTests(int UserId);

        [OperationContract]
        List<Test> GetAvailableTests(int userId);

        [OperationContract]
        void PassTest(int userId, int testId, double score);
    }

}
