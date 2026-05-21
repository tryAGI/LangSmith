
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsMessage
    {
        /// <summary>
        /// Example: what is your name?
        /// </summary>
        /// <example>what is your name?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Example: user
        /// </summary>
        /// <example>user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ThreadsMessageRoleJsonConverter))]
        public global::LangSmith.ThreadsMessageRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Example: what is your name?
        /// </param>
        /// <param name="role">
        /// Example: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsMessage(
            string? content,
            global::LangSmith.ThreadsMessageRole? role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsMessage" /> class.
        /// </summary>
        public ThreadsMessage()
        {
        }

    }
}