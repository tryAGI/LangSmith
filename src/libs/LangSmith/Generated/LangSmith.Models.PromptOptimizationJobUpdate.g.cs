
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobStatusJsonConverter))]
        public global::LangSmith.EPromptOptimizationJobStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::LangSmith.PromptOptimizationResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobUpdate" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="result"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptOptimizationJobUpdate(
            global::LangSmith.EPromptOptimizationJobStatus? status,
            global::LangSmith.PromptOptimizationResult? result)
        {
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobUpdate" /> class.
        /// </summary>
        public PromptOptimizationJobUpdate()
        {
        }
    }
}