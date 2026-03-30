
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsBulkDeleteEvaluatorFailedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsBulkDeleteEvaluatorFailedItem" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsBulkDeleteEvaluatorFailedItem(
            string? error,
            string? id)
        {
            this.Error = error;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsBulkDeleteEvaluatorFailedItem" /> class.
        /// </summary>
        public EvaluatorsBulkDeleteEvaluatorFailedItem()
        {
        }
    }
}