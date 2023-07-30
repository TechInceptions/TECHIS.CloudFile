using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.CloudFile
{

    public interface IConnector<TInterface>
    {
        TInterface Connect(string signedContainerUri, Encoding encoding = null);

        TInterface Connect(string storageAccountConnectionString, string connectionDetails, Encoding encoding = null);


        TInterface ConnectWithDefaultCredentials(string containerUri, Encoding encoding = null);

        TInterface ConnectWithDefaultCredentials(string storageAccountUri, string connectionDetails, Encoding encoding = null);
    }
}
