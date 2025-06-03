
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExamplesErrorResponse
    {
        /// <summary>
        /// Optional error details as JSON string<br/>
        /// Example: {"field":"dataset_id","reason":"required"}
        /// </summary>
        /// <example>{"field":"dataset_id","reason":"required"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Error message<br/>
        /// Example: Invalid request: missing required fields
        /// </summary>
        /// <example>Invalid request: missing required fields</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesErrorResponse" /> class.
        /// </summary>
        /// <param name="details">
        /// Optional error details as JSON string<br/>
        /// Example: {"field":"dataset_id","reason":"required"}
        /// </param>
        /// <param name="error">
        /// Error message<br/>
        /// Example: Invalid request: missing required fields
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExamplesErrorResponse(
            string? details,
            string? error)
        {
            this.Details = details;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesErrorResponse" /> class.
        /// </summary>
        public ExamplesErrorResponse()
        {
        }
    }
}