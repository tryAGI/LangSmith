
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiContextHubRepoMountSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexthub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxapiContextHubMountSpec Contexthub { get; set; }

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
        /// Initializes a new instance of the <see cref="SandboxapiContextHubRepoMountSpec" /> class.
        /// </summary>
        /// <param name="contexthub"></param>
        /// <param name="id"></param>
        /// <param name="mountPath"></param>
        /// <param name="type"></param>
        /// <param name="readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiContextHubRepoMountSpec(
            global::LangSmith.SandboxapiContextHubMountSpec contexthub,
            string id,
            string mountPath,
            global::LangSmith.SandboxapiMountKind type,
            bool? readOnly)
        {
            this.Contexthub = contexthub ?? throw new global::System.ArgumentNullException(nameof(contexthub));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.ReadOnly = readOnly;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiContextHubRepoMountSpec" /> class.
        /// </summary>
        public SandboxapiContextHubRepoMountSpec()
        {
        }

    }
}