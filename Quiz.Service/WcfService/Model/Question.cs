using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Quiz.Service.WcfService.Model
{
    [DataContract]
    public class Question
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string QuestionText;
        [DataMember]
        public List<Variant> Variants;
    }
}