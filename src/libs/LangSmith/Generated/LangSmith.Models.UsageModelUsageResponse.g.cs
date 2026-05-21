
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageModelUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::LangSmith.UsageModelUsage>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageModelUsageResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageModelUsageResponse(
            global::System.Collections.Generic.IList<global::LangSmith.UsageModelUsage>? models)
        {
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageModelUsageResponse" /> class.
        /// </summary>
        public UsageModelUsageResponse()
        {
        }

    }
}