
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiS3BucketMountSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache")]
        public global::LangSmith.SandboxapiMountCacheSpec? Cache { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxapiS3MountSpec S3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxapiMountKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxapiMountKind Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiS3BucketMountSpec" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mountPath"></param>
        /// <param name="s3"></param>
        /// <param name="type"></param>
        /// <param name="cache"></param>
        /// <param name="readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiS3BucketMountSpec(
            string id,
            string mountPath,
            global::LangSmith.SandboxapiS3MountSpec s3,
            global::LangSmith.SandboxapiMountKind type,
            global::LangSmith.SandboxapiMountCacheSpec? cache,
            bool? readOnly)
        {
            this.Cache = cache;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.ReadOnly = readOnly;
            this.S3 = s3 ?? throw new global::System.ArgumentNullException(nameof(s3));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiS3BucketMountSpec" /> class.
        /// </summary>
        public SandboxapiS3BucketMountSpec()
        {
        }

    }
}