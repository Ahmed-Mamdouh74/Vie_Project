using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vie_Cap.Shared;

namespace Vie_Cap.Client.Service
{
    public interface IAuthService
    {

        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(LoginModel request);



    }
}
