
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "type",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::LangSmith.SandboxapiContextHubRepoMountSpec), typeDiscriminator: "contexthub")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::LangSmith.SandboxapiGCSBucketMountSpec), typeDiscriminator: "gcs")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::LangSmith.SandboxapiGitRepoMountSpec), typeDiscriminator: "git")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::LangSmith.SandboxapiS3BucketMountSpec), typeDiscriminator: "s3")]
    public partial class SandboxapiMountSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache")]
        public global::LangSmith.SandboxapiMountCacheSpec? Cache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexthub")]
        public global::LangSmith.SandboxapiContextHubMountSpec? Contexthub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcs")]
        public global::LangSmith.SandboxapiGCSMountSpec? Gcs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public global::LangSmith.SandboxapiGitMountSpec? Git { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3")]
        public global::LangSmith.SandboxapiS3MountSpec? S3 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiMountSpec" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mountPath"></param>
        /// <param name="cache"></param>
        /// <param name="contexthub"></param>
        /// <param name="gcs"></param>
        /// <param name="git"></param>
        /// <param name="readOnly"></param>
        /// <param name="s3"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiMountSpec(
            string id,
            string mountPath,
            global::LangSmith.SandboxapiMountCacheSpec? cache,
            global::LangSmith.SandboxapiContextHubMountSpec? contexthub,
            global::LangSmith.SandboxapiGCSMountSpec? gcs,
            global::LangSmith.SandboxapiGitMountSpec? git,
            bool? readOnly,
            global::LangSmith.SandboxapiS3MountSpec? s3)
        {
            this.Cache = cache;
            this.Contexthub = contexthub;
            this.Gcs = gcs;
            this.Git = git;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.ReadOnly = readOnly;
            this.S3 = s3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiMountSpec" /> class.
        /// </summary>
        public SandboxapiMountSpec()
        {
        }

    }
}