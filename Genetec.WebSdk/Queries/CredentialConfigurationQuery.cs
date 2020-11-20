using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Queries
{

    //
    // Resumen:
    //     A class to query credential configuration
    //
    // Comentarios:
    //     Use this class to query for entities and populate the Genetec.Sdk.Engine entity
    //     cache. It is not recommended to use the dataset returned by this query directly.
    //     Instead one should obtain the Genetec.Sdk.Entities.Entity objects that were downloaded
    //     through the Genetec.Sdk.Engine.GetEntity(System.Guid) method
    //     The System.Data.DataTable returned from the query has the following schema:
    //     Column # Name Type Description 0 Guid System.Guid The unique identifier of the
    //     entity
    public sealed class CredentialConfigurationQuery : EntityConfigurationQuery
    {
        //
        // Resumen:
        //     Get the collection of entity types and subtypes queried.
        //public override EntityTypeCollection EntityTypeFilter { get; }
        //
        // Resumen:
        //     Get the IList of entity types queried/
        [Obsolete("Replaced by EntityTypeFilter.")]
        public override IList<EntityType> EntityTypes { get; }
        //
        // Resumen:
        //     Gets the list of unique ids to query for.
        //public CredentialUniqueIdCollection UniqueIds { get; }
        //
        // Resumen:
        //     Indicates that the query will return unassigned credentials only.
        public bool UnassignedOnly { get; set; }
    }
}
