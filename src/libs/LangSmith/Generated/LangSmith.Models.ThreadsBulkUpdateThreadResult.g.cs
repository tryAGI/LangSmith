
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsBulkUpdateThreadResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ThreadsBulkUpdateThreadResultStatusJsonConverter))]
        public global::LangSmith.ThreadsBulkUpdateThreadResultStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsBulkUpdateThreadResult" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsBulkUpdateThreadResult(
            string? errorCode,
            global::System.Guid? id,
            string? message,
            global::LangSmith.ThreadsBulkUpdateThreadResultStatus? status)
        {
            this.ErrorCode = errorCode;
            this.Id = id;
            this.Message = message;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsBulkUpdateThreadResult" /> class.
        /// </summary>
        public ThreadsBulkUpdateThreadResult()
        {
        }

    }
}