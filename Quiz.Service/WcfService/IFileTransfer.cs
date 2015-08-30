using System.Runtime.Serialization;
using System.ServiceModel;

namespace Quiz.Service.WcfService
{
    [ServiceContract]
    public interface IFileTransfer
    {
        [OperationContract]
        string UploadFile(byte[] data, string filename);

        [OperationContract]
        TransferedImage DownloadImage(string url);
    }


    [DataContract]
    public class TransferedImage
    {
        [DataMember] 
        public string Filename;

        [DataMember] public byte[] data;
    }
}
