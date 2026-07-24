
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiGCSMountSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiGCSMountSpec" /> class.
        /// </summary>
        /// <param name="bucket"></param>
        /// <param name="prefix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiGCSMountSpec(
            string bucket,
            string? prefix)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Prefix = prefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiGCSMountSpec" /> class.
        /// </summary>
        public SandboxapiGCSMountSpec()
        {
        }

    }
}