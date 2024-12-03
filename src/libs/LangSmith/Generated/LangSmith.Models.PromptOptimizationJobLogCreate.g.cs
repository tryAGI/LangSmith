
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationJobLogCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.EPromptOptimizationJobLogType LogType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobLogCreate" /> class.
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptOptimizationJobLogCreate(
            global::LangSmith.EPromptOptimizationJobLogType logType,
            string message,
            object? data)
        {
            this.LogType = logType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationJobLogCreate" /> class.
        /// </summary>
        public PromptOptimizationJobLogCreate()
        {
        }
    }
}