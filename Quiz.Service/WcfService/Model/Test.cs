using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Quiz.Service.WcfService.Model;

namespace QuizMaker.WcfService.Model
{
    [DataContract]
    public class Test: ITestModel
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string Name;
        [DataMember]
        public List<Question> Questions;
    }
}
