
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RulesProblemDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Details is a LangSmith extension carrying structured fields for ErrorClass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::LangSmith.SharedParseErrorDetails? Details { get; set; }

        /// <summary>
        /// ErrorClass is a LangSmith extension sub-categorizing a status code.<br/>
        /// Additional values require expanding this enum and adding a oneOf<br/>
        /// discriminator on Details to keep the class↔details contract typed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RulesProblemDetailsErrorClassJsonConverter))]
        public global::LangSmith.RulesProblemDetailsErrorClass? ErrorClass { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesProblemDetails" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="status"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
        /// <param name="details">
        /// Details is a LangSmith extension carrying structured fields for ErrorClass.
        /// </param>
        /// <param name="errorClass">
        /// ErrorClass is a LangSmith extension sub-categorizing a status code.<br/>
        /// Additional values require expanding this enum and adding a oneOf<br/>
        /// discriminator on Details to keep the class↔details contract typed.
        /// </param>
        /// <param name="instance"></param>
        /// <param name="remedy">
        /// Remedy is a LangSmith extension for user-recoverable errors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesProblemDetails(
            string detail,
            int status,
            string title,
            string type,
            global::LangSmith.SharedParseErrorDetails? details,
            global::LangSmith.RulesProblemDetailsErrorClass? errorClass,
            string? instance,
            string? remedy)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Details = details;
            this.ErrorClass = errorClass;
            this.Instance = instance;
            this.Remedy = remedy;
            this.Status = status;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesProblemDetails" /> class.
        /// </summary>
        public RulesProblemDetails()
        {
        }

    }
}