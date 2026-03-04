
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitsExampleRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsExampleRun" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitsExampleRun(
            global::System.Guid? id,
            object? inputs,
            object? outputs,
            global::System.Guid? sessionId,
            string? startTime)
        {
            this.Id = id;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.SessionId = sessionId;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsExampleRun" /> class.
        /// </summary>
        public CommitsExampleRun()
        {
        }
    }
}