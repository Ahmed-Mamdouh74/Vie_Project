using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vie_Cap.Client.Service
{
    public interface IActivitiesService
    {
        IList<Vie_Cap.Shared.Activity> ListActivity { get; set; }

        Task LoadActivityAsync();
    }
}
