
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretsSecretItem
    {
        /// <summary>
        /// Example: OPENAI_API_KEY
        /// </summary>
        /// <example>OPENAI_API_KEY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Set is always true for items returned by the list endpoint — a key only<br/>
        /// appears when it has a value. It lets a client diff this list against a<br/>
        /// model's required_secrets to find which required keys are still missing.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("set")]
        public bool? Set { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretsSecretItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: OPENAI_API_KEY
        /// </param>
        /// <param name="set">
        /// Set is always true for items returned by the list endpoint — a key only<br/>
        /// appears when it has a value. It lets a client diff this list against a<br/>
        /// model's required_secrets to find which required keys are still missing.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretsSecretItem(
            string? name,
            bool? set)
        {
            this.Name = name;
            this.Set = set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretsSecretItem" /> class.
        /// </summary>
        public SecretsSecretItem()
        {
        }

    }
}