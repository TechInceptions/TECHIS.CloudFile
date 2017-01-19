using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{
    public interface ICloudFileWriterFactory
    {
        ICloudFileWriter Connect(string containerUri, Encoding encoding = null);

        ICloudFileWriter Connect(string azureStorageConnectionString, string containerName, Encoding encoding = null);
    }
}
