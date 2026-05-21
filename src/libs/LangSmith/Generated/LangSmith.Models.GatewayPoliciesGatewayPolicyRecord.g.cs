
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayPoliciesGatewayPolicyRecord
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// CurrentSpendUSD is the spend in the policy's current window. Set for<br/>
        /// any spend_cap policy regardless of enabled state — disabled policies<br/>
        /// still surface usage so users can see what would have been counted.<br/>
        /// Nil for non-spend_cap policies or when the spend lookup failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_spend_usd")]
        public double? CurrentSpendUsd { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_system_generated")]
        public bool? IsSystemGenerated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// ParentPolicyID is set on materialized children of a default_spend_cap<br/>
        /// to the default's id, and cleared (NULL) only when an admin Create<br/>
        /// with the same matchers takes over the materialized row. Update on a<br/>
        /// child preserves the link; Delete on the parent cascade-soft-deletes<br/>
        /// every child rather than detaching them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_policy_id")]
        public string? ParentPolicyId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesGatewayPolicyRecord" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="config"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="currentSpendUsd">
        /// CurrentSpendUSD is the spend in the policy's current window. Set for<br/>
        /// any spend_cap policy regardless of enabled state — disabled policies<br/>
        /// still surface usage so users can see what would have been counted.<br/>
        /// Nil for non-spend_cap policies or when the spend lookup failed.
        /// </param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="id"></param>
        /// <param name="isSystemGenerated"></param>
        /// <param name="name"></param>
        /// <param name="organizationId"></param>
        /// <param name="parentPolicyId">
        /// ParentPolicyID is set on materialized children of a default_spend_cap<br/>
        /// to the default's id, and cleared (NULL) only when an admin Create<br/>
        /// with the same matchers takes over the materialized row. Update on a<br/>
        /// child preserves the link; Delete on the parent cascade-soft-deletes<br/>
        /// every child rather than detaching them.
        /// </param>
        /// <param name="policyType"></param>
        /// <param name="priority"></param>
        /// <param name="subjectMatchers"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayPoliciesGatewayPolicyRecord(
            string? action,
            object? config,
            string? createdAt,
            string? createdBy,
            double? currentSpendUsd,
            string? description,
            bool? enabled,
            string? id,
            bool? isSystemGenerated,
            string? name,
            string? organizationId,
            string? parentPolicyId,
            string? policyType,
            int? priority,
            global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? subjectMatchers,
            string? updatedAt)
        {
            this.Action = action;
            this.Config = config;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.CurrentSpendUsd = currentSpendUsd;
            this.Description = description;
            this.Enabled = enabled;
            this.Id = id;
            this.IsSystemGenerated = isSystemGenerated;
            this.Name = name;
            this.OrganizationId = organizationId;
            this.ParentPolicyId = parentPolicyId;
            this.PolicyType = policyType;
            this.Priority = priority;
            this.SubjectMatchers = subjectMatchers;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesGatewayPolicyRecord" /> class.
        /// </summary>
        public GatewayPoliciesGatewayPolicyRecord()
        {
        }

    }
}