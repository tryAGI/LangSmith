
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesTemplateListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesTemplateResponse>? Templates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesTemplateListResponse" /> class.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="templates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesTemplateListResponse(
            int? offset,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesTemplateResponse>? templates)
        {
            this.Offset = offset;
            this.Templates = templates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesTemplateListResponse" /> class.
        /// </summary>
        public SandboxesTemplateListResponse()
        {
        }
    }
}