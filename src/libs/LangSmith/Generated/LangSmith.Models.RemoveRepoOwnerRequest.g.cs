
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request to remove a repo owner.
    /// </summary>
    public sealed partial class RemoveRepoOwnerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid IdentityId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveRepoOwnerRequest" /> class.
        /// </summary>
        /// <param name="identityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveRepoOwnerRequest(
            global::System.Guid identityId)
        {
            this.IdentityId = identityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveRepoOwnerRequest" /> class.
        /// </summary>
        public RemoveRepoOwnerRequest()
        {
        }
    }
}