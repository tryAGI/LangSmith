
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesAccessControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_list")]
        public global::System.Collections.Generic.IList<string>? AllowList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deny_list")]
        public global::System.Collections.Generic.IList<string>? DenyList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesAccessControl" /> class.
        /// </summary>
        /// <param name="allowList"></param>
        /// <param name="denyList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesAccessControl(
            global::System.Collections.Generic.IList<string>? allowList,
            global::System.Collections.Generic.IList<string>? denyList)
        {
            this.AllowList = allowList;
            this.DenyList = denyList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesAccessControl" /> class.
        /// </summary>
        public SandboxesAccessControl()
        {
        }
    }
}