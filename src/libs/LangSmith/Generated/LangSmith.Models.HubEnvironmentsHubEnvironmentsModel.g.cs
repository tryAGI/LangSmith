
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HubEnvironmentsHubEnvironmentsModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HubEnvironmentsHubEnvironmentsModel" /> class.
        /// </summary>
        /// <param name="environments"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HubEnvironmentsHubEnvironmentsModel(
            global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>? environments,
            string? id)
        {
            this.Environments = environments;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubEnvironmentsHubEnvironmentsModel" /> class.
        /// </summary>
        public HubEnvironmentsHubEnvironmentsModel()
        {
        }
    }
}