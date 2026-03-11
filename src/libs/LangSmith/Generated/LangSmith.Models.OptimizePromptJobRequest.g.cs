
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request to optimize a prompt.
    /// </summary>
    public sealed partial class OptimizePromptJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.EPromptOptimizationAlgorithm Algorithm { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig> Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptJobRequest" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        /// <param name="promptName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizePromptJobRequest(
            global::LangSmith.EPromptOptimizationAlgorithm algorithm,
            global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig> config,
            string promptName)
        {
            this.Algorithm = algorithm;
            this.Config = config;
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptJobRequest" /> class.
        /// </summary>
        public OptimizePromptJobRequest()
        {
        }
    }
}