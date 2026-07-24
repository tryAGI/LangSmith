
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayPoliciesSearchGatewayPoliciesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        public string? PolicyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_matcher_key")]
        public string? SubjectMatcherKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_matcher_values")]
        public global::System.Collections.Generic.IList<string>? SubjectMatcherValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesSearchGatewayPoliciesRequest" /> class.
        /// </summary>
        /// <param name="policyType"></param>
        /// <param name="subjectMatcherKey"></param>
        /// <param name="subjectMatcherValues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayPoliciesSearchGatewayPoliciesRequest(
            string? policyType,
            string? subjectMatcherKey,
            global::System.Collections.Generic.IList<string>? subjectMatcherValues)
        {
            this.PolicyType = policyType;
            this.SubjectMatcherKey = subjectMatcherKey;
            this.SubjectMatcherValues = subjectMatcherValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesSearchGatewayPoliciesRequest" /> class.
        /// </summary>
        public GatewayPoliciesSearchGatewayPoliciesRequest()
        {
        }

    }
}