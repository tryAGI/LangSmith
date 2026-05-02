
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsReplaceAuthMethodsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_methods")]
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthMethod>? AuthMethods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsReplaceAuthMethodsRequest" /> class.
        /// </summary>
        /// <param name="authMethods"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsReplaceAuthMethodsRequest(
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthMethod>? authMethods)
        {
            this.AuthMethods = authMethods;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsReplaceAuthMethodsRequest" /> class.
        /// </summary>
        public IntegrationsReplaceAuthMethodsRequest()
        {
        }
    }
}