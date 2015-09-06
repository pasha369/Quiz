using System.ServiceModel;
using Quiz.Service.WcfService.Model;

namespace Quiz.Service.WcfService.Abstract
{
    /// <summary>
    /// Service for transfer test images
    /// </summary>
    [ServiceContract]
    public interface IFileTransfer
    {
        [OperationContract]
        string UploadFile(byte[] data, string filename);

        [OperationContract]
        TransferedImage DownloadImage(string url);
    }
}
