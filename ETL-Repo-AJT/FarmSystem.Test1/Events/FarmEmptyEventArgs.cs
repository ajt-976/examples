using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Events
{
    public class FarmEmptyEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
