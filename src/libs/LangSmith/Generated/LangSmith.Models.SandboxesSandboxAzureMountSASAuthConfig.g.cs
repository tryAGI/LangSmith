
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxAzureMountSASAuthConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sas_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesProxySecretValue SasToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxAzureMountSASAuthConfig" /> class.
        /// </summary>
        /// <param name="sasToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxAzureMountSASAuthConfig(
            global::LangSmith.SandboxesProxySecretValue sasToken)
        {
            this.SasToken = sasToken ?? throw new global::System.ArgumentNullException(nameof(sasToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxAzureMountSASAuthConfig" /> class.
        /// </summary>
        public SandboxesSandboxAzureMountSASAuthConfig()
        {
        }

    }
}