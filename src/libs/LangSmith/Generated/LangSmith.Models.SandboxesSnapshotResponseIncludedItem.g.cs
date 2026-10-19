
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesSnapshotResponseIncludedItem
    {
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
    public static class SandboxesSnapshotResponseIncludedItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesSnapshotResponseIncludedItem value)
        {
            return value switch
            {
                SandboxesSnapshotResponseIncludedItem.EnvVars => "env_vars",
                SandboxesSnapshotResponseIncludedItem.Labels => "labels",
                SandboxesSnapshotResponseIncludedItem.Lifecycle => "lifecycle",
                SandboxesSnapshotResponseIncludedItem.Mounts => "mounts",
                SandboxesSnapshotResponseIncludedItem.ProxyConfig => "proxy_config",
                SandboxesSnapshotResponseIncludedItem.Resources => "resources",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesSnapshotResponseIncludedItem? ToEnum(string value)
        {
            return value switch
            {
                "env_vars" => SandboxesSnapshotResponseIncludedItem.EnvVars,
                "labels" => SandboxesSnapshotResponseIncludedItem.Labels,
                "lifecycle" => SandboxesSnapshotResponseIncludedItem.Lifecycle,
                "mounts" => SandboxesSnapshotResponseIncludedItem.Mounts,
                "proxy_config" => SandboxesSnapshotResponseIncludedItem.ProxyConfig,
                "resources" => SandboxesSnapshotResponseIncludedItem.Resources,
                _ => null,
            };
        }
    }
}