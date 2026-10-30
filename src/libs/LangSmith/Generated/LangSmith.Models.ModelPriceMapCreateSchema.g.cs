
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A custom model price entry for the workspace.
    /// </summary>
    public sealed partial class ModelPriceMapCreateSchema
    {
        /// <summary>
        /// Display name for the entry, usually the model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Only price runs that started at or after this time. Null applies to runs from any time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Invocation parameter keys checked, in order, for the model name when the run does not report `ls_model_name` metadata.<br/>
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_path")]
        public global::System.Collections.Generic.IList<string>? MatchPath { get; set; }

        /// <summary>
        /// Regular expression matched against the run's model name, for example `^gpt-4o-mini$`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MatchPattern { get; set; }

        /// <summary>
        /// Cost in US dollars per input (prompt) token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<double?, string> PromptCost { get; set; }

        /// <summary>
        /// Cost in US dollars per output (completion) token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<double?, string> CompletionCost { get; set; }

        /// <summary>
        /// Cost in US dollars per input token for specific token types, keyed by the token detail name the run reports, for example `cache_read`. Input tokens not covered here are priced at `prompt_cost`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost_details")]
        public object? PromptCostDetails { get; set; }

        /// <summary>
        /// Cost in US dollars per output token for specific token types, keyed by the token detail name the run reports, for example `audio`. Output tokens not covered here are priced at `completion_cost`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost_details")]
        public object? CompletionCostDetails { get; set; }

        /// <summary>
        /// Only price runs from this provider (the `ls_provider` metadata, case-insensitive), for example `openai` or `anthropic`. Null matches any provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Only price requests with more input tokens than this, for long-context pricing tiers. Null applies to every request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_above")]
        public int? PromptTokensAbove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapCreateSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name for the entry, usually the model name.
        /// </param>
        /// <param name="matchPattern">
        /// Regular expression matched against the run's model name, for example `^gpt-4o-mini$`.
        /// </param>
        /// <param name="promptCost">
        /// Cost in US dollars per input (prompt) token.
        /// </param>
        /// <param name="completionCost">
        /// Cost in US dollars per output (completion) token.
        /// </param>
        /// <param name="startTime">
        /// Only price runs that started at or after this time. Null applies to runs from any time.
        /// </param>
        /// <param name="matchPath">
        /// Invocation parameter keys checked, in order, for the model name when the run does not report `ls_model_name` metadata.<br/>
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="promptCostDetails">
        /// Cost in US dollars per input token for specific token types, keyed by the token detail name the run reports, for example `cache_read`. Input tokens not covered here are priced at `prompt_cost`.
        /// </param>
        /// <param name="completionCostDetails">
        /// Cost in US dollars per output token for specific token types, keyed by the token detail name the run reports, for example `audio`. Output tokens not covered here are priced at `completion_cost`.
        /// </param>
        /// <param name="provider">
        /// Only price runs from this provider (the `ls_provider` metadata, case-insensitive), for example `openai` or `anthropic`. Null matches any provider.
        /// </param>
        /// <param name="promptTokensAbove">
        /// Only price requests with more input tokens than this, for long-context pricing tiers. Null applies to every request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPriceMapCreateSchema(
            string name,
            string matchPattern,
            global::LangSmith.AnyOf<double?, string> promptCost,
            global::LangSmith.AnyOf<double?, string> completionCost,
            global::System.DateTime? startTime,
            global::System.Collections.Generic.IList<string>? matchPath,
            object? promptCostDetails,
            object? completionCostDetails,
            string? provider,
            int? promptTokensAbove)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.StartTime = startTime;
            this.MatchPath = matchPath;
            this.MatchPattern = matchPattern ?? throw new global::System.ArgumentNullException(nameof(matchPattern));
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.PromptCostDetails = promptCostDetails;
            this.CompletionCostDetails = completionCostDetails;
            this.Provider = provider;
            this.PromptTokensAbove = promptTokensAbove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapCreateSchema" /> class.
        /// </summary>
        public ModelPriceMapCreateSchema()
        {
        }

    }
}