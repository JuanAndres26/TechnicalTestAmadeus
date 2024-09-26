using Moq;
using skyBook.Unitest.Stubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagmentService;

namespace skyBook.Unitest.Mock
{
    public class MockUserManagment
    {
        public Mock<IUserManagment> moq { get; set; }

        public MockUserManagment(string type)
        {
            moq = new Mock<IUserManagment>();

            switch (type)
            {
                case "ReturnError":
                    RetunError();
                    break;
                case "FuntionReady":
                    RetunReady();
                    break;
                default:
                    break;
            }
        }

        private void RetunReady()
        {
            moq.Setup(x => x.validateUserAsync(It.IsAny<validateUserRequest>())).Returns(ValidateUserResponseStub.User);
        }

        private void RetunError()
        {
            moq.Setup(x => x.validateUserAsync(It.IsAny<validateUserRequest>())).Throws(new Exception("No se encontraron datos"));
        }
    }
}

