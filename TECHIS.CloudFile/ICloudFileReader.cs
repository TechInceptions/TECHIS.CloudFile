using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{
    public interface ICloudFileReader
    {


        string ReadText(string fileName);

        Task<string> ReadTextAsync(string fileName);

        Task ReadDataAsync(string fileName, Stream output);

    }
}
