
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunShareSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid ShareToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunShareSchema" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="shareToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunShareSchema(
            global::System.Guid runId,
            global::System.Guid shareToken)
        {
            this.RunId = runId;
            this.ShareToken = shareToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunShareSchema" /> class.
        /// </summary>
        public RunShareSchema()
        {
        }
    }
}