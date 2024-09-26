using skyBook.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.@interface
{
    [ServiceContract]

    public interface IUserManagment
    {
        [OperationContract]
        User validateUser(string username, string password);
    }
}
