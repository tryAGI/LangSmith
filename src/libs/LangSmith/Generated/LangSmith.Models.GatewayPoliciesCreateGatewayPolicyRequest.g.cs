
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayPoliciesCreateGatewayPolicyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_type")]
        public string? PolicyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_matchers")]
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? SubjectMatchers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesCreateGatewayPolicyRequest" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="config"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="name"></param>
        /// <param name="policyType"></param>
        /// <param name="priority"></param>
        /// <param name="subjectMatchers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayPoliciesCreateGatewayPolicyRequest(
            string? action,
            object? config,
            string? description,
            bool? enabled,
            string? name,
            string? policyType,
            int? priority,
            global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? subjectMatchers)
        {
            this.Action = action;
            this.Config = config;
            this.Description = description;
            this.Enabled = enabled;
            this.Name = name;
            this.PolicyType = policyType;
            this.Priority = priority;
            this.SubjectMatchers = subjectMatchers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesCreateGatewayPolicyRequest" /> class.
        /// </summary>
        public GatewayPoliciesCreateGatewayPolicyRequest()
        {
        }

    }
}