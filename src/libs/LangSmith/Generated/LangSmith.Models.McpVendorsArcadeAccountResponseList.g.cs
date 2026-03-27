
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpVendorsArcadeAccountResponseList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>? Organizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsArcadeAccountResponseList" /> class.
        /// </summary>
        /// <param name="organizations"></param>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpVendorsArcadeAccountResponseList(
            global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>? organizations,
            global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>? projects)
        {
            this.Organizations = organizations;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsArcadeAccountResponseList" /> class.
        /// </summary>
        public McpVendorsArcadeAccountResponseList()
        {
        }
    }
}