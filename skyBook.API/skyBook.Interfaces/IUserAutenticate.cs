using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using skyBook.Entiti;

namespace skyBook.Interfaces
{
    public interface IUserAutenticate
    {
        object AutenticateUser(RequestAutenticate request);
    }
}
