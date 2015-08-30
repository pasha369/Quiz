using System;
using System.ServiceModel;

namespace Quiz.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(Quiz.Service.WcfService.Service));
            sh.Open();
            Console.ReadLine();
            sh.Close();
        }
    }
}
