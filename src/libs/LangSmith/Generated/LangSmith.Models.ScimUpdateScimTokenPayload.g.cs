
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimUpdateScimTokenPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUpdateScimTokenPayload" /> class.
        /// </summary>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScimUpdateScimTokenPayload(
            string? description)
        {
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUpdateScimTokenPayload" /> class.
        /// </summary>
        public ScimUpdateScimTokenPayload()
        {
        }
    }
}