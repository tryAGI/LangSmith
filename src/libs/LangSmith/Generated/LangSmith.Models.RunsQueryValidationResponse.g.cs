
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response for POST /runs/query/validate.
    /// </summary>
    public sealed partial class RunsQueryValidationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsQueryValidationResponse" /> class.
        /// </summary>
        /// <param name="valid"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsQueryValidationResponse(
            bool valid,
            global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>? errors)
        {
            this.Valid = valid;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsQueryValidationResponse" /> class.
        /// </summary>
        public RunsQueryValidationResponse()
        {
        }
    }
}