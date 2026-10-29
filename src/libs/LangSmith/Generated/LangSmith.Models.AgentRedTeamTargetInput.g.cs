
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRedTeamTargetInput
    {
        /// <summary>
        /// Headers are write-only and required unless clearing. An empty value<br/>
        /// keeps that header's saved value while the url is unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetInput" /> class.
        /// </summary>
        /// <param name="headers">
        /// Headers are write-only and required unless clearing. An empty value<br/>
        /// keeps that header's saved value while the url is unchanged.
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRedTeamTargetInput(
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? url)
        {
            this.Headers = headers;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRedTeamTargetInput" /> class.
        /// </summary>
        public AgentRedTeamTargetInput()
        {
        }

    }
}