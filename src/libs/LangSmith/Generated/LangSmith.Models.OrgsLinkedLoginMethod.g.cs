
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsLinkedLoginMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// provisioning_method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioning")]
        public string? Provisioning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsLinkedLoginMethod" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="provisioning">
        /// provisioning_method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsLinkedLoginMethod(
            string? provider,
            string? provisioning)
        {
            this.Provider = provider;
            this.Provisioning = provisioning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsLinkedLoginMethod" /> class.
        /// </summary>
        public OrgsLinkedLoginMethod()
        {
        }
    }
}