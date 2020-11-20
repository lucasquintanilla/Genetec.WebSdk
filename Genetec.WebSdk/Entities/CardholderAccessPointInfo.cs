using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities
{
    public class CardholderAccessPointInfo
    {
        public Guid AccessPointGuid { get; set; }
        public DateTime AccessPointDate { get; set; }
        public bool AccessGranted { get; set; }
    }
}
