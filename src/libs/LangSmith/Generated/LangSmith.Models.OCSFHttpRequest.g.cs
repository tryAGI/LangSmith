
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF HTTP request object.
    /// </summary>
    public sealed partial class OCSFHttpRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HttpMethod { get; set; }

        /// <summary>
        /// OCSF URL object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFUrl Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFHttpRequest" /> class.
        /// </summary>
        /// <param name="httpMethod"></param>
        /// <param name="url">
        /// OCSF URL object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFHttpRequest(
            string httpMethod,
            global::LangSmith.OCSFUrl url)
        {
            this.HttpMethod = httpMethod ?? throw new global::System.ArgumentNullException(nameof(httpMethod));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFHttpRequest" /> class.
        /// </summary>
        public OCSFHttpRequest()
        {
        }
    }
}