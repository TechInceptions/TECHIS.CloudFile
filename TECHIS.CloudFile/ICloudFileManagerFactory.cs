using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TECHIS.CloudFile
{
    public interface ICloudFileManagerFactory
    {
        ICloudFileManager Connect(string signedContainerUri, Encoding encoding = null);

        ICloudFileManager Connect(string storageAccountConnectionString, string connectionDetails, Encoding encoding = null);
    }
}
