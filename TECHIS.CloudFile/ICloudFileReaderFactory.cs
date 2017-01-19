using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{
    public interface ICloudFileReaderFactory
    {
        ICloudFileReader Connect(string containerUri, Encoding encoding = null);

        ICloudFileReader Connect(string azureStorageConnectionString, string containerName, Encoding encoding = null);
    }
}
