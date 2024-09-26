using NLog;
using skyBook.database;
using skyBook.database.Internal;
using skyBook.Entiti;
using skyBook.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.impl
{
    internal class UserManagmentImpl : IUserManagment
    {
        private readonly IdataProvider provider;
        private readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public UserManagmentImpl() {
            DatabaseInitializer.InitializeDatabase();
            provider = new dataProvider();
        }
        public User validateUser(string username, string password)
        {
            try {
                this.logger.Info($"start query validateUser with user : {username}");
                var response  = provider.validateUserConection(username, password);
                this.logger.Info($"succesfull validation user : {username}");
                return response; 
            } catch (Exception ex) {
                this.logger.Error($"Error of validation user :{username} ERROR : {ex}");
                throw;
            }
            
        }
    }
}
