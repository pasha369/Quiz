using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace QuizMaker.WcfService.Model
{
    [DataContract]
    public class Variant
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string VariantText;
    }
}
