using System.Runtime.Serialization;

namespace Quiz.Service.WcfService.Model
{
    [DataContract]
    public class Variant
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string VariantText;
        [DataMember]
        public string Type;
        [DataMember]
        public string ImageUri;

    }
}
