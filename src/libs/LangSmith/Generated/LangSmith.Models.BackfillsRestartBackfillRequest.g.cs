
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackfillsRestartBackfillRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_name")]
        public string? BackfillName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillsRestartBackfillRequest" /> class.
        /// </summary>
        /// <param name="backfillName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackfillsRestartBackfillRequest(
            string? backfillName)
        {
            this.BackfillName = backfillName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillsRestartBackfillRequest" /> class.
        /// </summary>
        public BackfillsRestartBackfillRequest()
        {
        }
    }
}