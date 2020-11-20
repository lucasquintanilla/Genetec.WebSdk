using Genetec.WebSdk.Entities.AccessControl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Drawing;

namespace Genetec.WebSdk.Entities
{
    public class ActivationMode
    {
    }

    public class EntityCollection
    {
        [JsonProperty("item")]
        public IEnumerable<ItemGuid> Collection { get; set; }
    }

    public class ItemGuid
    {
        public Guid Guid { get; set; }
    }

    public class CredentialCollection : EntityCollection
    {
        //[JsonProperty("item")]
        //public IEnumerable<ItemGuid<T>> Collection { get; set; }
    }

    public class CardholderGroupCollection : EntityCollection
    {
        //[JsonProperty("item")]
        //public IEnumerable<ItemGuid<T>> Collection { get; set; }
    }

    public class AccessRules : EntityCollection
    {
        //[JsonProperty("item")]
        //public IEnumerable<ItemGuid<T>> Collection { get; set; }
    }

    public class Parents : EntityCollection
    {
        //[JsonProperty("item")]
        //public IEnumerable<ItemGuid<T>> Collection { get; set; }
    }

    //public class Cardholder : Entity
    //{
    //    public DateTime ActivationDate { get; set; }
    //    public ActivationMode ActivationMode { get; set; }
    //    public string ActiveDirectoryDomainName { get; set; }
    //    public bool CanEscort { get; set; }
    //    public bool AntipassbackExemption { get; set; }
    //    public CredentialCollection Credentials { get; set; }
    //    public string EmailAddress { get; set; }
    //    public DateTime ExpirationDate { get; set; }
    //    public int ExpirationDuration { get; set; }
    //    public string FirstName { get; set; }
    //    public CardholderGroupCollection Groups { get; set; }
    //    public int AccessPermissionLevel { get; set; }
    //    public AccessRules AccessRules { get; set; }
    //    public bool InheritAccessPermissionLevel { get; set; }
    //    public CardholderAccessPointInfo LastAccessPoint { get; set; }
    //    public string LastName { get; set; }
    //    public Parents Parents { get; set; }
    //    public string Picture { get; set; }
    //    public string PictureFileName { get; set; }
    //    public CardholderState State { get; set; }
    //    public CardholderAccessStatus Status { get; set; }
    //    public bool UseExtendedGrantTime { get; set; }      
    //}

    public class Cardholder : Entity
    {
        //
        // Resumen:
        //     Gets or sets the first name of the cardholder.
        public string FirstName { get; set; }
        //
        // Resumen:
        //     Gets the path of the cardholder's photo.
        public string PictureFileName { get; set; }
        //
        // Resumen:
        //     Gets or Sets the photo of the cardholder.
        //
        // Comentarios:
        //     The setter can set pictures for native cardholders and Active Directory cardholders.
        //     It throws an SdkException for federated cardholders or cardholders owned by a
        //     plugin (unless the plugin is setting the picture of one of its cardholder). For
        //     Active Directory cardholders, the cardholder images will be uploaded at the next
        //     Active Directory synchronization and the synchronization synchronizes everything.
        //     Other conditions for a picture set in Security Center to be uploaded to the Active
        //     Directory: - the Active Directory role must have the "Upload picture to Active
        //     Directory" option enabled. - a link must be configured between the Security Center
        //     Cardholder picture field and the Active Directory cardholder attribute. Refer
        //     to the Security Center Administrator Guide.
        public string Picture { get; set; }
        //
        // Resumen:
        //     Gets the parents of the cardholder.
        public Parents Parents { get; set; }
        //
        // Resumen:
        //     Gets the last name of the cardholder.
        public string LastName { get; set; }
        //
        // Resumen:
        //     Gets the cardholder's last known location.
        //
        // Comentarios:
        //     Cardholder location refers to the last AccessPoint the cardholder transited to.
        public CardholderAccessPointInfo LastAccessPoint { get; set; }
        //
        // Resumen:
        //     Gets InheritAccessPermissionLevel of the Genetec.Sdk.Entities.Cardholder. true
        //     when Genetec.Sdk.Entities.Cardholder.AccessPermissionLevel is inherited from
        //     parent group. false otherwise.
        public bool InheritAccessPermissionLevel { get; set; }
        //
        // Resumen:
        //     Gets Access Rules associates to this cardholder.
        public AccessRules AccessRules { get; set; }
        //
        // Resumen:
        //     Gets the Access Permission Level of the Genetec.Sdk.Entities.Cardholder This
        //     property is called Security clearance in Config Tool under the cardholder properties.
        public int AccessPermissionLevel { get; set; }
        //
        // Resumen:
        //     Gets the groups associated to this cardholder.
        public CardholderGroupCollection Groups { get; set; }
        //
        // Resumen:
        //     Gets the expiration duration for this cardholder.
        //
        // Comentarios:
        //     Expiration duration is in days.
        [Obsolete("Use Status.ExpirationDuration instead.")]
        public int ExpirationDuration { get; set; }
        //
        // Resumen:
        //     Gets or Sets the current cardholder state.
        //
        // Excepciones:
        //   T:System.InvalidOperationException:
        //     The state of a cardholder cannot be set to lost or stolen.
        [Obsolete("Use Status property instead.")]
        public CardholderState State { get; set; }
        //
        // Resumen:
        //     Gets the expiration date for this Genetec.Sdk.Entities.Cardholder.
        //
        // Comentarios:
        //     Expiration date can be set using ActivationMode. If the ExpirationDate is DateTime.MinValue,
        //     it means that the entity will never expire.
        [Obsolete("Use Status.ExpirationDate instead.")]
        public DateTime ExpirationDate { get; set; }
        //
        // Resumen:
        //     Gets the list of cardholder's credentials.
        public CredentialCollection Credentials { get; set; }
        //
        // Resumen:
        //     Gets or sets if this Genetec.Sdk.Entities.Cardholder is exempted from antipassback
        //     rules.
        //
        // Comentarios:
        //     An antipassback violation occurs when a cardholder enters an area that he never
        //     exited, or when he exits an area that he never entered. This can occur when an
        //     authorized cardholder unlocks a door, and while entering, passes their card back
        //     to somebody else.
        public bool AntipassbackExemption { get; set; }
        //
        // Resumen:
        //     Gets or set ability of cardhodler to be selected to escort visitors
        public bool CanEscort { get; set; }
        //
        // Resumen:
        //     Gets the active directory domain name if this entity is imported from an active
        //     directory. Otherwise it returns an empty string.
        public string ActiveDirectoryDomainName { get; set; }
        //
        // Resumen:
        //     Gets or sets the activation mode for this Genetec.Sdk.Entities.Cardholder.
        [Obsolete("Use Status property instead.")]
        public ActivationMode ActivationMode { get; set; }
        //
        // Resumen:
        //     Gets the activation date for this Genetec.Sdk.Entities.Cardholder.
        //
        // Comentarios:
        //     Activation date can be set using ActivationMode.
        [Obsolete("Use Status.ActivationDate instead.")]
        public DateTime ActivationDate { get; set; }
        //
        // Resumen:
        //     Gets or sets if this Genetec.Sdk.Entities.Cardholder uses extended grant time.
        //     true if this Genetec.Sdk.Entities.Cardholder uses extended grant time; otherwise,
        //     false
        public bool UseExtendedGrantTime { get; set; }
        //
        // Resumen:
        //     Gets or sets the email address of the cardholder.
        public string EmailAddress { get; set; }
        //
        // Resumen:
        //     Gets the cardholder's access status.
        public CardholderAccessStatus Status { get; set; }

        public Image GetPicture()
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(this.Picture);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}
