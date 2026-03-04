
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthzInternalListAccessPoliciesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_policies")]
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>? AccessPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalListAccessPoliciesResponse" /> class.
        /// </summary>
        /// <param name="accessPolicies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthzInternalListAccessPoliciesResponse(
            global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>? accessPolicies)
        {
            this.AccessPolicies = accessPolicies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalListAccessPoliciesResponse" /> class.
        /// </summary>
        public AuthzInternalListAccessPoliciesResponse()
        {
        }
    }
}