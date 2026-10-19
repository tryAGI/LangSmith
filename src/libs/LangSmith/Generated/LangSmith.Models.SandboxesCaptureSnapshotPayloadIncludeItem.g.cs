
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesCaptureSnapshotPayloadIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        EnvVars,
        /// <summary>
        ///
        /// </summary>
        Labels,
        /// <summary>
        ///
        /// </summary>
        Lifecycle,
        /// <summary>
        ///
        /// </summary>
        Mounts,
        /// <summary>
        ///
        /// </summary>
        ProxyConfig,
        /// <summary>
        ///
        /// </summary>
        Resources,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesCaptureSnapshotPayloadIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesCaptureSnapshotPayloadIncludeItem value)
        {
            return value switch
            {
                SandboxesCaptureSnapshotPayloadIncludeItem.All => "all",
                SandboxesCaptureSnapshotPayloadIncludeItem.EnvVars => "env_vars",
                SandboxesCaptureSnapshotPayloadIncludeItem.Labels => "labels",
                SandboxesCaptureSnapshotPayloadIncludeItem.Lifecycle => "lifecycle",
                SandboxesCaptureSnapshotPayloadIncludeItem.Mounts => "mounts",
                SandboxesCaptureSnapshotPayloadIncludeItem.ProxyConfig => "proxy_config",
                SandboxesCaptureSnapshotPayloadIncludeItem.Resources => "resources",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesCaptureSnapshotPayloadIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "all" => SandboxesCaptureSnapshotPayloadIncludeItem.All,
                "env_vars" => SandboxesCaptureSnapshotPayloadIncludeItem.EnvVars,
                "labels" => SandboxesCaptureSnapshotPayloadIncludeItem.Labels,
                "lifecycle" => SandboxesCaptureSnapshotPayloadIncludeItem.Lifecycle,
                "mounts" => SandboxesCaptureSnapshotPayloadIncludeItem.Mounts,
                "proxy_config" => SandboxesCaptureSnapshotPayloadIncludeItem.ProxyConfig,
                "resources" => SandboxesCaptureSnapshotPayloadIncludeItem.Resources,
                _ => null,
            };
        }
    }
}