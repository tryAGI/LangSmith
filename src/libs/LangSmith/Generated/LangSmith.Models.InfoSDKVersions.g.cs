
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfoSDKVersions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_go_sdk_version")]
        public string? MaxGoSdkVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_java_sdk_version")]
        public string? MaxJavaSdkVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_js_sdk_version")]
        public string? MaxJsSdkVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_python_sdk_version")]
        public string? MaxPythonSdkVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoSDKVersions" /> class.
        /// </summary>
        /// <param name="maxGoSdkVersion"></param>
        /// <param name="maxJavaSdkVersion"></param>
        /// <param name="maxJsSdkVersion"></param>
        /// <param name="maxPythonSdkVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoSDKVersions(
            string? maxGoSdkVersion,
            string? maxJavaSdkVersion,
            string? maxJsSdkVersion,
            string? maxPythonSdkVersion)
        {
            this.MaxGoSdkVersion = maxGoSdkVersion;
            this.MaxJavaSdkVersion = maxJavaSdkVersion;
            this.MaxJsSdkVersion = maxJsSdkVersion;
            this.MaxPythonSdkVersion = maxPythonSdkVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoSDKVersions" /> class.
        /// </summary>
        public InfoSDKVersions()
        {
        }

    }
}