
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HubEnvironmentsCreateEnvironmentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry> Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HubEnvironmentsCreateEnvironmentsRequest" /> class.
        /// </summary>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HubEnvironmentsCreateEnvironmentsRequest(
            global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry> environments)
        {
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubEnvironmentsCreateEnvironmentsRequest" /> class.
        /// </summary>
        public HubEnvironmentsCreateEnvironmentsRequest()
        {
        }
    }
}