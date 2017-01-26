using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{
    public interface ICloudFileReaderFactory
    {
        ICloudFileReader Connect(string signedContainerUri, Encoding encoding = null);

        ICloudFileReader Connect(string storageAccountConnectionString, string connectionDetails, Encoding encoding = null);
    }
}
