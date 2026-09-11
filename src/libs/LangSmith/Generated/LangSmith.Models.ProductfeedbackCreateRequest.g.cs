
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProductfeedbackCreateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ProductfeedbackCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.ProductfeedbackCategory Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public global::LangSmith.ProductfeedbackClientContext? Client { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ProductfeedbackSourceJsonConverter))]
        public global::LangSmith.ProductfeedbackSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductfeedbackCreateRequest" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="message"></param>
        /// <param name="client"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductfeedbackCreateRequest(
            global::LangSmith.ProductfeedbackCategory category,
            string message,
            global::LangSmith.ProductfeedbackClientContext? client,
            global::LangSmith.ProductfeedbackSource source)
        {
            this.Category = category;
            this.Client = client;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductfeedbackCreateRequest" /> class.
        /// </summary>
        public ProductfeedbackCreateRequest()
        {
        }

    }
}