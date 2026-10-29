
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxUsageDailyResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageDaily> Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageDailyResponse" /> class.
        /// </summary>
        /// <param name="entries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxUsageDailyResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageDaily> entries)
        {
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageDailyResponse" /> class.
        /// </summary>
        public SandboxesSandboxUsageDailyResponse()
        {
        }

    }
}