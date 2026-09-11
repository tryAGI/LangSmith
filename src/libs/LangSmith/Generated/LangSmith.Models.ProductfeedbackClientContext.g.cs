
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProductfeedbackClientContext
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        public string? Os { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductfeedbackClientContext" /> class.
        /// </summary>
        /// <param name="architecture"></param>
        /// <param name="os"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductfeedbackClientContext(
            string? architecture,
            string? os,
            string? version)
        {
            this.Architecture = architecture;
            this.Os = os;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductfeedbackClientContext" /> class.
        /// </summary>
        public ProductfeedbackClientContext()
        {
        }

    }
}