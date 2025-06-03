
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Patch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post")]
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Post { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="patch"></param>
        /// <param name="post"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request(
            global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? patch,
            global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? post)
        {
            this.Patch = patch;
            this.Post = post;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
        }
    }
}