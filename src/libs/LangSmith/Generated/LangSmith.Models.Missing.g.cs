
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Missing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__missing__")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.MissingMissing1JsonConverter))]
        public global::LangSmith.MissingMissing1 Missing1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Missing" /> class.
        /// </summary>
        /// <param name="missing1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Missing(
            global::LangSmith.MissingMissing1 missing1)
        {
            this.Missing1 = missing1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Missing" /> class.
        /// </summary>
        public Missing()
        {
        }
    }
}