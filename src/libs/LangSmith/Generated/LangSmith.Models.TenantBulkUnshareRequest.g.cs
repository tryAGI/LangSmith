
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantBulkUnshareRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_tokens")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ShareTokens { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unshare_all")]
        public bool? UnshareAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantBulkUnshareRequest" /> class.
        /// </summary>
        /// <param name="shareTokens"></param>
        /// <param name="unshareAll">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantBulkUnshareRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? shareTokens,
            bool? unshareAll)
        {
            this.ShareTokens = shareTokens;
            this.UnshareAll = unshareAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantBulkUnshareRequest" /> class.
        /// </summary>
        public TenantBulkUnshareRequest()
        {
        }
    }
}