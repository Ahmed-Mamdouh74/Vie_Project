using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vie_Cap.Shared;

namespace Vie_Cap.Client.Service
{
   public interface IcompanyService
    {
        event Action OnChange;
        List<ModeViewCompany> companies { get; set; }

        //Task<List<ModeViewCompany>> Postcompany(ModeViewCompany company);
        Task<ModeViewCompany> Postcompany(ModeViewCompany company);

    }
}
