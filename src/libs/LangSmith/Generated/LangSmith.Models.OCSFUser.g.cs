
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF user object within actor.
    /// </summary>
    public sealed partial class OCSFUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public global::System.Guid? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_uid")]
        public global::System.Guid? CredentialUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFUser" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="credentialUid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFUser(
            global::System.Guid? uid,
            global::System.Guid? credentialUid)
        {
            this.Uid = uid;
            this.CredentialUid = credentialUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFUser" /> class.
        /// </summary>
        public OCSFUser()
        {
        }
    }
}