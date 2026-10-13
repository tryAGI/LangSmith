
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxapiMountEncryptionSpec
    {
        /// <summary>
        /// KMSKey is the key to encrypt uploads with. S3 mounts take a KMS key ARN in the mount's region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KmsKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiMountEncryptionSpec" /> class.
        /// </summary>
        /// <param name="kmsKey">
        /// KMSKey is the key to encrypt uploads with. S3 mounts take a KMS key ARN in the mount's region.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiMountEncryptionSpec(
            string kmsKey)
        {
            this.KmsKey = kmsKey ?? throw new global::System.ArgumentNullException(nameof(kmsKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiMountEncryptionSpec" /> class.
        /// </summary>
        public SandboxapiMountEncryptionSpec()
        {
        }

    }
}