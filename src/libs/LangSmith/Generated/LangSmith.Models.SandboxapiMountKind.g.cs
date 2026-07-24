
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxapiMountKind
    {
        /// <summary>
        /// 
        /// </summary>
        MountKindContextHub,
        /// <summary>
        /// 
        /// </summary>
        MountKindGCS,
        /// <summary>
        /// 
        /// </summary>
        MountKindGit,
        /// <summary>
        /// 
        /// </summary>
        MountKindS3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxapiMountKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxapiMountKind value)
        {
            return value switch
            {
                SandboxapiMountKind.MountKindContextHub => "contexthub",
                SandboxapiMountKind.MountKindGCS => "gcs",
                SandboxapiMountKind.MountKindGit => "git",
                SandboxapiMountKind.MountKindS3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxapiMountKind? ToEnum(string value)
        {
            return value switch
            {
                "contexthub" => SandboxapiMountKind.MountKindContextHub,
                "gcs" => SandboxapiMountKind.MountKindGCS,
                "git" => SandboxapiMountKind.MountKindGit,
                "s3" => SandboxapiMountKind.MountKindS3,
                _ => null,
            };
        }
    }
}