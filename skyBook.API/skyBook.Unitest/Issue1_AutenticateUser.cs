using Castle.Core.Configuration;
using Moq;
using skyBook.Impl;
using skyBook.Interfaces;
using skyBook.Unitest.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagmentService;

namespace skyBook.Unitest
{
    [TestClass]
    public class Issue1_AutenticateUser
    {
        public Mock<IUserManagment>? moqUserManagment;
       

        [TestMethod]
        public void AutenticateUserError()
        {
            //start
            moqUserManagment = new MockUserManagment("ReturnError").moq;
            IUserAutenticate autenticate = new UserAutenticateImpl(moqUserManagment.Object);
            try
            {
                //act
                var respone = autenticate.AutenticateUser(new Entiti.RequestAutenticate());
                //asset
                Assert.IsTrue(false);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void AutenticateUserOk()
        {
            //start
            moqUserManagment = new MockUserManagment("FuntionReady").moq;
            IUserAutenticate autenticate = new UserAutenticateImpl(moqUserManagment.Object);
            try
            {
                //act
                var respone = autenticate.AutenticateUser(new Entiti.RequestAutenticate());
                //asset
                Assert.IsNotNull(respone);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

    }
}
