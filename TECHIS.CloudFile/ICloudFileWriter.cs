using System.IO;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{
    public interface ICloudFileWriter
    {
        void WriteToBlob(Stream ms, string fileName);
        void WriteToBlob(byte[] data, string fileName);

        Task WriteToBlobAsync(Stream ms, string fileName);
        Task WriteToBlobAsync(byte[] data, string fileName);
    }
}
