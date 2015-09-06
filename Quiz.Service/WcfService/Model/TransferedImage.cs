using System.Runtime.Serialization;

namespace Quiz.Service.WcfService.Model
{
    /// <summary>
    /// Transfered Image model
    /// </summary>
    [DataContract]
    public class TransferedImage
    {
        [DataMember] 
        public string Filename;

        [DataMember] public byte[] data;
    }
}