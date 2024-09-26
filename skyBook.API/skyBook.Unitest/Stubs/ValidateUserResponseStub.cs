using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagmentService;

namespace skyBook.Unitest.Stubs
{
    public static class ValidateUserResponseStub
    {
        public static Task<validateUserResponse> User()
        {
            var tcs = new TaskCompletionSource<validateUserResponse>();


            var task = new validateUserResponse() { validateUserResult = new User() { Id = 1, Username = "pepe"} };
           
            tcs.SetResult(task);

            return tcs.Task;
        }
    }
}
