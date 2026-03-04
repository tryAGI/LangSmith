
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthzInternalAttachAccessPoliciesPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_policy_ids")]
        public global::System.Collections.Generic.IList<string>? AccessPolicyIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalAttachAccessPoliciesPayload" /> class.
        /// </summary>
        /// <param name="accessPolicyIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthzInternalAttachAccessPoliciesPayload(
            global::System.Collections.Generic.IList<string>? accessPolicyIds)
        {
            this.AccessPolicyIds = accessPolicyIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalAttachAccessPoliciesPayload" /> class.
        /// </summary>
        public AuthzInternalAttachAccessPoliciesPayload()
        {
        }
    }
}