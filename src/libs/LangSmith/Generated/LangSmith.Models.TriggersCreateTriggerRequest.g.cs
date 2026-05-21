
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggersCreateTriggerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_id")]
        public string? RegistrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggersCreateTriggerRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="config"></param>
        /// <param name="name"></param>
        /// <param name="registrationId"></param>
        /// <param name="status"></param>
        /// <param name="templateId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggersCreateTriggerRequest(
            string? agentId,
            object? config,
            string? name,
            string? registrationId,
            string? status,
            string? templateId)
        {
            this.AgentId = agentId;
            this.Config = config;
            this.Name = name;
            this.RegistrationId = registrationId;
            this.Status = status;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggersCreateTriggerRequest" /> class.
        /// </summary>
        public TriggersCreateTriggerRequest()
        {
        }

    }
}