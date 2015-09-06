using System.Runtime.Serialization;

namespace Quiz.Service.WcfService.Model
{
    [DataContract]
    public class Answer
    {
        [DataMember]
        public int id;
        [DataMember]
        public int questionId;
        [DataMember]
        public int? variantId;
    }
}
