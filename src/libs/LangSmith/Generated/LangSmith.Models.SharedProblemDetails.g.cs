
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// RFC 7807 problem details returned on V2 API errors.
    /// </summary>
    public sealed partial class SharedProblemDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance")]
        public string? Instance { get; set; }

        /// <summary>
        /// Remedy is a LangSmith extension for user-recoverable errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remedy")]
        public string? Remedy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedProblemDetails" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="instance"></param>
        /// <param name="remedy">
        /// Remedy is a LangSmith extension for user-recoverable errors.
        /// </param>
        /// <param name="status"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedProblemDetails(
            string? detail,
            string? instance,
            string? remedy,
            int? status,
            string? title,
            string? type)
        {
            this.Detail = detail;
            this.Instance = instance;
            this.Remedy = remedy;
            this.Status = status;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedProblemDetails" /> class.
        /// </summary>
        public SharedProblemDetails()
        {
        }

    }
}