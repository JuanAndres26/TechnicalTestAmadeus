using NLog;
using skyBook.Entiti;
using skyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagmentService;

namespace skyBook.Impl
{
    public class UserAutenticateImpl : IUserAutenticate
    {
        private readonly IUserManagment userManagment;
        private readonly NLog.ILogger logger = LogManager.GetCurrentClassLogger();
        public UserAutenticateImpl() {
            userManagment = new UserManagmentClient();
        }
        public UserAutenticateImpl(IUserManagment userManagment_)
        {
            userManagment = userManagment_;
        }
        public object AutenticateUser(RequestAutenticate request)
        {
            try {
                var response = userManagment.validateUserAsync(new validateUserRequest() { password = request.Password, username = request.UserName }).Result.validateUserResult;
                return response;
            } catch (Exception ex) {
                this.logger.Error($"Error in  UserAutenticateImpl  ERROR: {ex}");
                throw;
            }
            
        }
    }
}
