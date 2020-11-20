using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.AccessControl
{
    public class CardholderAccessStatus
    {
        public DateTime? ActivationDate { get; set; }
        public ActivationType ActivationType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public ExpirationType ExpirationType { get; set; }
        public int? ExpirationDuration { get; set; }
        public CardholderState State { get; set; }
    }
}
