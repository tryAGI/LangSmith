
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Resolved annotation queue run position for deep linking.
    /// </summary>
    public sealed partial class ResolvedAnnotationQueueRunSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.ResolvedAnnotationQueueRunSchemaSection Section { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedAnnotationQueueRunSchema" /> class.
        /// </summary>
        /// <param name="section"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolvedAnnotationQueueRunSchema(
            global::LangSmith.ResolvedAnnotationQueueRunSchemaSection section,
            int position)
        {
            this.Section = section;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedAnnotationQueueRunSchema" /> class.
        /// </summary>
        public ResolvedAnnotationQueueRunSchema()
        {
        }
    }
}