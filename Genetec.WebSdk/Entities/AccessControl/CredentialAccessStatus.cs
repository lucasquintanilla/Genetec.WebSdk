using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Entities.AccessControl
{
    public class CredentialAccessStatus : AccessStatus
    {
        //
        // Resumen:
        //     Gets the credential's activation date.
        public override DateTime? ActivationDate { get; set; }
        //
        // Resumen:
        //     Gets the credential's activation type.
        public override ActivationType ActivationType { get; set; }
        //
        // Resumen:
        //     Gets the credential's expiration date.
        public override DateTime? ExpirationDate { get; set; }
        //
        // Resumen:
        //     Gets the credential's expiration type.
        public override ExpirationType ExpirationType { get; set; }
        //
        // Resumen:
        //     Gets the credential's expiration duration
        public override int? ExpirationDuration { get; set; }
        //
        // Resumen:
        //     Gets the credential's state.
        public CredentialState State { get; set; }
    }
}
