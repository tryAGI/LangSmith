
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCreatePoolPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_ready")]
        public bool? WaitForReady { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreatePoolPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replicas"></param>
        /// <param name="templateName"></param>
        /// <param name="timeout"></param>
        /// <param name="waitForReady"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreatePoolPayload(
            string name,
            int replicas,
            string templateName,
            int? timeout,
            bool? waitForReady)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Replicas = replicas;
            this.TemplateName = templateName ?? throw new global::System.ArgumentNullException(nameof(templateName));
            this.Timeout = timeout;
            this.WaitForReady = waitForReady;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreatePoolPayload" /> class.
        /// </summary>
        public SandboxesCreatePoolPayload()
        {
        }
    }
}