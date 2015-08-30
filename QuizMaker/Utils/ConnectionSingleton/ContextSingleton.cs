using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.Models.DatabaseEntity;

namespace QuizMaker.Utils.ConnectionSingleton
{
    /// <summary>
    /// Implement instance for QuizDBEntities
    /// </summary>
    static class ContextSingleton
    {
        private static QuizDBEntities instance;

        public static QuizDBEntities Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new QuizDBEntities();
                }
                return instance; 
            }
        }
    }

}
