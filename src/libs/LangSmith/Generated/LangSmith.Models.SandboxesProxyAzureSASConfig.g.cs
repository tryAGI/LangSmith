
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesProxyAzureSASConfig
    {
        /// <summary>
        /// StorageAccount is the storage account static credentials authenticate to: requests to its blob, dfs, queue, table and file endpoints. Requires exactly one of account_key (requests are signed with SharedKey) or sas_token (appended to each request).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StorageAccount { get; set; }

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
        /// Initializes a new instance of the <see cref="SandboxesProxyAzureSASConfig" /> class.
        /// </summary>
        /// <param name="storageAccount">
        /// StorageAccount is the storage account static credentials authenticate to: requests to its blob, dfs, queue, table and file endpoints. Requires exactly one of account_key (requests are signed with SharedKey) or sas_token (appended to each request).
        /// </param>
        /// <param name="sasToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyAzureSASConfig(
            string storageAccount,
            global::LangSmith.SandboxesProxySecretValue sasToken)
        {
            this.StorageAccount = storageAccount ?? throw new global::System.ArgumentNullException(nameof(storageAccount));
            this.SasToken = sasToken ?? throw new global::System.ArgumentNullException(nameof(sasToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAzureSASConfig" /> class.
        /// </summary>
        public SandboxesProxyAzureSASConfig()
        {
        }

    }
}