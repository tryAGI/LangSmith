
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsFileEntry
    {
        /// <summary>
        /// File contents as a UTF-8 string.<br/>
        /// Example: # AGENTS.md<br/>
        /// You are a helpful agent.
        /// </summary>
        /// <example>
        /// # AGENTS.md<br/>
        /// You are a helpful agent.
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsFileEntry" /> class.
        /// </summary>
        /// <param name="content">
        /// File contents as a UTF-8 string.<br/>
        /// Example: # AGENTS.md<br/>
        /// You are a helpful agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsFileEntry(
            string? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsFileEntry" /> class.
        /// </summary>
        public AgentsFileEntry()
        {
        }

    }
}