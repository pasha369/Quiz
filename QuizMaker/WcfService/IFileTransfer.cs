using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace QuizMaker.WcfService
{
    [ServiceContract]
    public interface IFileTransfer
    {
        [OperationContract]
        void UploadFile(TransImage request);
    }


    [DataContract]
    public class TransImage
    {
        [DataMember] 
        public string Filename;

        [DataMember] public byte[] data;
    }
}
