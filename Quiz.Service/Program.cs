using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Quiz.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(Quiz.Service.WcfService.Service));

            ServiceDebugBehavior debug = sh.Description.Behaviors.Find<ServiceDebugBehavior>();

            // if not found - add behavior with setting turned on 
            if (debug == null)
            {
                sh.Description.Behaviors.Add(
                     new ServiceDebugBehavior() { IncludeExceptionDetailInFaults = true });
            }
            else
            {
                // make sure setting is turned ON
                if (!debug.IncludeExceptionDetailInFaults)
                {
                    debug.IncludeExceptionDetailInFaults = true;
                }
            }

            
            sh.Open();
            Console.ReadLine();
            sh.Close();
        }
    }
}
