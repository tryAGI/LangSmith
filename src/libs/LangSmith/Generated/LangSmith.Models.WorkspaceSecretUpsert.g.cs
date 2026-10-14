
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspaceSecretUpsert
    {
        /// <summary>
        /// Secret value. Required to create a secret; omit to keep the current value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Full replacement of the allowed hosts. Omitted or empty removes custom hosts so the built-in defaults, if any, apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfigInput>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecretUpsert" /> class.
        /// </summary>
        /// <param name="value">
        /// Secret value. Required to create a secret; omit to keep the current value.
        /// </param>
        /// <param name="configs">
        /// Full replacement of the allowed hosts. Omitted or empty removes custom hosts so the built-in defaults, if any, apply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceSecretUpsert(
            string? value,
            global::System.Collections.Generic.IList<global::LangSmith.SecretConfigInput>? configs)
        {
            this.Value = value;
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecretUpsert" /> class.
        /// </summary>
        public WorkspaceSecretUpsert()
        {
        }

    }
}