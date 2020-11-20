using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Actions
{
    //
    // Resumen:
    //     The base class for actions
    //
    // Comentarios:
    //     An Action is a user-programmable function that can be triggered as an automatic
    //     response to an event (door held open for too long, or object left unattended)
    //     or executed according to a specific time table.
    public class Action
    {
        //
        // Resumen:
        //     Gets the resource ID representing the name of the action
        public int ActionName { get; }
        //
        // Resumen:
        //     Gets the type of action
        public ActionType Type { get; }
        //
        // Resumen:
        //     Gets or sets the recipient
        public Guid Recipient { get; set; }
        //
        // Resumen:
        //     Returns the list of all recipients. Can be used for single and multi recipient
        //     actions
        public IEnumerable<Guid> AllRecipients { get; }
        //
        // Resumen:
        //     Returns the list of recipient entity types
        public IEnumerable<EntityType> RecipientEntityTypes { get; }
        //
        // Resumen:
        //     Gets or sets the schedule
        public Guid Schedule { get; set; }
    }
}
