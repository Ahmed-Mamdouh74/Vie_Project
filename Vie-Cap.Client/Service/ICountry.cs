using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vie_Cap.Client.Service
{
    public interface ICountry
    {
        IList<Vie_Cap.Shared.Country> Countries { get; set; }

        Task LoadCounrtAsync();


    }
}
