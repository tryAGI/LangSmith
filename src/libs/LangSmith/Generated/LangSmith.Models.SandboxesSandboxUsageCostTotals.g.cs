
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxUsageCostTotals
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lcu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lcu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lsu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lsu { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCostTotals" /> class.
        /// </summary>
        /// <param name="lcu"></param>
        /// <param name="lsu"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxUsageCostTotals(
            string lcu,
            string lsu)
        {
            this.Lcu = lcu ?? throw new global::System.ArgumentNullException(nameof(lcu));
            this.Lsu = lsu ?? throw new global::System.ArgumentNullException(nameof(lsu));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCostTotals" /> class.
        /// </summary>
        public SandboxesSandboxUsageCostTotals()
        {
        }

    }
}