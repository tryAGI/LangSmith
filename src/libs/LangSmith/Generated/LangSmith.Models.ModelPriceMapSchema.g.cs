
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Model price map schema.
    /// </summary>
    public sealed partial class ModelPriceMapSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public global::System.Guid? TenantId { get; set; }

        /// <summary>
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_path")]
        public global::System.Collections.Generic.IList<string>? MatchPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MatchPattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost_details")]
        public global::System.Collections.Generic.Dictionary<string, string>? PromptCostDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost_details")]
        public global::System.Collections.Generic.Dictionary<string, string>? CompletionCostDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapSchema" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="matchPattern"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="tenantId"></param>
        /// <param name="matchPath">
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="promptCostDetails"></param>
        /// <param name="completionCostDetails"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPriceMapSchema(
            string name,
            string matchPattern,
            string promptCost,
            string completionCost,
            global::System.Guid? id,
            global::System.DateTime? startTime,
            global::System.Guid? tenantId,
            global::System.Collections.Generic.IList<string>? matchPath,
            global::System.Collections.Generic.Dictionary<string, string>? promptCostDetails,
            global::System.Collections.Generic.Dictionary<string, string>? completionCostDetails,
            string? provider)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.StartTime = startTime;
            this.TenantId = tenantId;
            this.MatchPath = matchPath;
            this.MatchPattern = matchPattern ?? throw new global::System.ArgumentNullException(nameof(matchPattern));
            this.PromptCost = promptCost ?? throw new global::System.ArgumentNullException(nameof(promptCost));
            this.CompletionCost = completionCost ?? throw new global::System.ArgumentNullException(nameof(completionCost));
            this.PromptCostDetails = promptCostDetails;
            this.CompletionCostDetails = completionCostDetails;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapSchema" /> class.
        /// </summary>
        public ModelPriceMapSchema()
        {
        }

    }
}