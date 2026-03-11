
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExamplesDeleteExamplesRequest
    {
        /// <summary>
        /// ExampleIDs is a list of UUIDs identifying the examples to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExampleIds { get; set; }

        /// <summary>
        /// HardDelete indicates whether to perform a hard delete.<br/>
        /// Currently only True is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hard_delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HardDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesDeleteExamplesRequest" /> class.
        /// </summary>
        /// <param name="exampleIds">
        /// ExampleIDs is a list of UUIDs identifying the examples to delete.
        /// </param>
        /// <param name="hardDelete">
        /// HardDelete indicates whether to perform a hard delete.<br/>
        /// Currently only True is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExamplesDeleteExamplesRequest(
            global::System.Collections.Generic.IList<string> exampleIds,
            bool hardDelete)
        {
            this.ExampleIds = exampleIds ?? throw new global::System.ArgumentNullException(nameof(exampleIds));
            this.HardDelete = hardDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesDeleteExamplesRequest" /> class.
        /// </summary>
        public ExamplesDeleteExamplesRequest()
        {
        }
    }
}