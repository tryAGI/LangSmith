
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsBulkDeleteEvaluatorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        public global::System.Collections.Generic.IList<string>? Succeeded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsBulkDeleteEvaluatorsResponse" /> class.
        /// </summary>
        /// <param name="failed"></param>
        /// <param name="succeeded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsBulkDeleteEvaluatorsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? failed,
            global::System.Collections.Generic.IList<string>? succeeded)
        {
            this.Failed = failed;
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsBulkDeleteEvaluatorsResponse" /> class.
        /// </summary>
        public EvaluatorsBulkDeleteEvaluatorsResponse()
        {
        }
    }
}