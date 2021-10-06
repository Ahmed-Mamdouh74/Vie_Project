using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vie_Cap.Shared;

namespace Vie_Cap.Server.Service
{
    public interface IUtilityService
    {
        Task<User> GetUser();

    }
}
