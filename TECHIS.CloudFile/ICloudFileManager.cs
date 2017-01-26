using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{
    public interface ICloudFileManager
    {
        void Delete(string fileName);
        string[] List(string containerPath);
        Task DeleteAsync(string fileName);
        Task<string[]> ListAsync(string containerPath);
    }
}
