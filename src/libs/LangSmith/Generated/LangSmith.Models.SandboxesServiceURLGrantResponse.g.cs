
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesServiceURLGrantResponse
    {
        /// <summary>
        /// How the port is shared: "token" for a minted service token, or<br/>
        /// "restricted"/"workspace" for LangSmith login.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesServiceURLGrantResponseAccessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesServiceURLGrantResponseAccess Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The LangSmith user who first shared this port, when known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::System.Guid? CreatedBy { get; set; }

        /// <summary>
        /// When the share expires. Set only for "token"; a login grant does not expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Port { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLGrantResponse" /> class.
        /// </summary>
        /// <param name="access">
        /// How the port is shared: "token" for a minted service token, or<br/>
        /// "restricted"/"workspace" for LangSmith login.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="port"></param>
        /// <param name="createdBy">
        /// The LangSmith user who first shared this port, when known.
        /// </param>
        /// <param name="expiresAt">
        /// When the share expires. Set only for "token"; a login grant does not expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesServiceURLGrantResponse(
            global::LangSmith.SandboxesServiceURLGrantResponseAccess access,
            global::System.DateTime createdAt,
            int port,
            global::System.Guid? createdBy,
            global::System.DateTime? expiresAt)
        {
            this.Access = access;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.ExpiresAt = expiresAt;
            this.Port = port;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLGrantResponse" /> class.
        /// </summary>
        public SandboxesServiceURLGrantResponse()
        {
        }

    }
}