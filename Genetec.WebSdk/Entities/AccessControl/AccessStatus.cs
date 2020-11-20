using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.AccessControl
{
    public abstract class AccessStatus
    {

        //
        // Resumen:
        //     Gets the activation date.
        public abstract DateTime? ActivationDate { get; set; }
        //
        // Resumen:
        //     Gets the activation type.
        public abstract ActivationType ActivationType { get; set; }
        //
        // Resumen:
        //     Gets the expiration type.
        public abstract ExpirationType ExpirationType { get; set; }
        //
        // Resumen:
        //     Gets the expiration date.
        public abstract DateTime? ExpirationDate { get; set; }
        //
        // Resumen:
        //     Gets the expiration duration.
        public abstract int? ExpirationDuration { get; set; }
    }
}
