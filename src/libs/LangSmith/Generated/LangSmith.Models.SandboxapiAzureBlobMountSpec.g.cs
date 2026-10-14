
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxapiAzureBlobMountSpec
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Container { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// StorageAccount is the storage account name: 3 to 24 lowercase letters and digits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StorageAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiAzureBlobMountSpec" /> class.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="storageAccount">
        /// StorageAccount is the storage account name: 3 to 24 lowercase letters and digits.
        /// </param>
        /// <param name="prefix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiAzureBlobMountSpec(
            string container,
            string storageAccount,
            string? prefix)
        {
            this.Container = container ?? throw new global::System.ArgumentNullException(nameof(container));
            this.Prefix = prefix;
            this.StorageAccount = storageAccount ?? throw new global::System.ArgumentNullException(nameof(storageAccount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiAzureBlobMountSpec" /> class.
        /// </summary>
        public SandboxapiAzureBlobMountSpec()
        {
        }

    }
}