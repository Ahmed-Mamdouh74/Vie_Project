using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vie_Cap.Shared
{
    public class ServiceResponse<t>
    {
        public t Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; }
    }
}
