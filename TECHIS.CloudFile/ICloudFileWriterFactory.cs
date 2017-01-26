using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{
    public interface ICloudFileWriterFactory
    {
        ICloudFileWriter Connect(string signedContainerUri, Encoding encoding = null);

        ICloudFileWriter Connect(string storageAccountConnectionString, string connectionDetails, Encoding encoding = null);
    }
}
