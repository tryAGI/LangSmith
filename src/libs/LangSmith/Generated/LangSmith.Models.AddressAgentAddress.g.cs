
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddressAgentAddress
    {
        /// <summary>
        /// `environment` is the Agent environment.<br/>
        /// Example: PRODUCTION
        /// </summary>
        /// <example>PRODUCTION</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AddressAgentAddressEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AddressAgentAddressEnvironment Environment { get; set; }

        /// <summary>
        /// `id` is the Agent's user-assigned id.<br/>
        /// Example: support-agent
        /// </summary>
        /// <example>support-agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AddressAgentAddressKindJsonConverter))]
        public global::LangSmith.AddressAgentAddressKind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressAgentAddress" /> class.
        /// </summary>
        /// <param name="environment">
        /// `environment` is the Agent environment.<br/>
        /// Example: PRODUCTION
        /// </param>
        /// <param name="id">
        /// `id` is the Agent's user-assigned id.<br/>
        /// Example: support-agent
        /// </param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddressAgentAddress(
            global::LangSmith.AddressAgentAddressEnvironment environment,
            string id,
            global::LangSmith.AddressAgentAddressKind kind)
        {
            this.Environment = environment;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressAgentAddress" /> class.
        /// </summary>
        public AddressAgentAddress()
        {
        }

    }
}