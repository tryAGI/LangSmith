
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentBuilderWebhooksWebhookTestResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_body")]
        public string? UpstreamBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_content_type")]
        public string? UpstreamContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_status_code")]
        public int? UpstreamStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBuilderWebhooksWebhookTestResult" /> class.
        /// </summary>
        /// <param name="upstreamBody"></param>
        /// <param name="upstreamContentType"></param>
        /// <param name="upstreamStatusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBuilderWebhooksWebhookTestResult(
            string? upstreamBody,
            string? upstreamContentType,
            int? upstreamStatusCode)
        {
            this.UpstreamBody = upstreamBody;
            this.UpstreamContentType = upstreamContentType;
            this.UpstreamStatusCode = upstreamStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBuilderWebhooksWebhookTestResult" /> class.
        /// </summary>
        public AgentBuilderWebhooksWebhookTestResult()
        {
        }
    }
}