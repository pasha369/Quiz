using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Quiz.Service.WcfService.Model
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
