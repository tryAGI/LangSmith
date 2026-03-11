
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF actor object.
    /// </summary>
    public sealed partial class OCSFActor
    {
        /// <summary>
        /// OCSF user object within actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.OCSFUser User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFActor" /> class.
        /// </summary>
        /// <param name="user">
        /// OCSF user object within actor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFActor(
            global::LangSmith.OCSFUser user)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFActor" /> class.
        /// </summary>
        public OCSFActor()
        {
        }
    }
}