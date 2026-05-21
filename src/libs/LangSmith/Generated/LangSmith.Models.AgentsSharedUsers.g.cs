
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSharedUsers
    {
        /// <summary>
        /// User IDs allowed to read the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        public global::System.Collections.Generic.IList<string>? Read { get; set; }

        /// <summary>
        /// User IDs allowed to run the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        public global::System.Collections.Generic.IList<string>? Run { get; set; }

        /// <summary>
        /// User IDs allowed to update the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        public global::System.Collections.Generic.IList<string>? Update { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSharedUsers" /> class.
        /// </summary>
        /// <param name="read">
        /// User IDs allowed to read the agent.
        /// </param>
        /// <param name="run">
        /// User IDs allowed to run the agent.
        /// </param>
        /// <param name="update">
        /// User IDs allowed to update the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsSharedUsers(
            global::System.Collections.Generic.IList<string>? read,
            global::System.Collections.Generic.IList<string>? run,
            global::System.Collections.Generic.IList<string>? update)
        {
            this.Read = read;
            this.Run = run;
            this.Update = update;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSharedUsers" /> class.
        /// </summary>
        public AgentsSharedUsers()
        {
        }

    }
}