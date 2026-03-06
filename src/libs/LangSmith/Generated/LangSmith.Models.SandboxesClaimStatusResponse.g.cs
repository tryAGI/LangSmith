
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesClaimStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesClaimStatusResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statusMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesClaimStatusResponse(
            string? status,
            string? statusMessage)
        {
            this.Status = status;
            this.StatusMessage = statusMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesClaimStatusResponse" /> class.
        /// </summary>
        public SandboxesClaimStatusResponse()
        {
        }
    }
}