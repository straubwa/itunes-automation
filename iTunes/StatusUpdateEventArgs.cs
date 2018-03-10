using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesCOMSample
{
    public class StatusUpdateEventArgs: EventArgs
    {
        public string Message { get; set; }
    }
}
