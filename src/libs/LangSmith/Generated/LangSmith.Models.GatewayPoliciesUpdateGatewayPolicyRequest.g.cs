
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayPoliciesUpdateGatewayPolicyRequest
    {
        /// <summary>
        /// Example: block
        /// </summary>
        /// <example>block</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Example: Blocks overspend on the production org
        /// </summary>
        /// <example>Blocks overspend on the production org</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Example: monthly-cap
        /// </summary>
        /// <example>monthly-cap</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
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
        /// Initializes a new instance of the <see cref="GatewayPoliciesUpdateGatewayPolicyRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// Example: block
        /// </param>
        /// <param name="config"></param>
        /// <param name="description">
        /// Example: Blocks overspend on the production org
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="name">
        /// Example: monthly-cap
        /// </param>
        /// <param name="priority">
        /// Example: 0
        /// </param>
        /// <param name="subjectMatchers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayPoliciesUpdateGatewayPolicyRequest(
            string? action,
            object? config,
            string? description,
            bool? enabled,
            string? name,
            int? priority,
            global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? subjectMatchers)
        {
            this.Action = action;
            this.Config = config;
            this.Description = description;
            this.Enabled = enabled;
            this.Name = name;
            this.Priority = priority;
            this.SubjectMatchers = subjectMatchers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesUpdateGatewayPolicyRequest" /> class.
        /// </summary>
        public GatewayPoliciesUpdateGatewayPolicyRequest()
        {
        }

    }
}