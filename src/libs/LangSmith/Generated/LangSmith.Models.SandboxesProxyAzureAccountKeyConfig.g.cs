
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesProxyAzureAccountKeyConfig
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
        [global::System.Text.Json.Serialization.JsonPropertyName("account_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesProxySecretValue AccountKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAzureAccountKeyConfig" /> class.
        /// </summary>
        /// <param name="storageAccount">
        /// StorageAccount is the storage account static credentials authenticate to: requests to its blob, dfs, queue, table and file endpoints. Requires exactly one of account_key (requests are signed with SharedKey) or sas_token (appended to each request).
        /// </param>
        /// <param name="accountKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyAzureAccountKeyConfig(
            string storageAccount,
            global::LangSmith.SandboxesProxySecretValue accountKey)
        {
            this.StorageAccount = storageAccount ?? throw new global::System.ArgumentNullException(nameof(storageAccount));
            this.AccountKey = accountKey ?? throw new global::System.ArgumentNullException(nameof(accountKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyAzureAccountKeyConfig" /> class.
        /// </summary>
        public SandboxesProxyAzureAccountKeyConfig()
        {
        }

    }
}