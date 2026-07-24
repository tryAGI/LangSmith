
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxapiMountSpecDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Contexthub,
        /// <summary>
        /// 
        /// </summary>
        Gcs,
        /// <summary>
        /// 
        /// </summary>
        Git,
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxapiMountSpecDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxapiMountSpecDiscriminatorType value)
        {
            return value switch
            {
                SandboxapiMountSpecDiscriminatorType.Contexthub => "contexthub",
                SandboxapiMountSpecDiscriminatorType.Gcs => "gcs",
                SandboxapiMountSpecDiscriminatorType.Git => "git",
                SandboxapiMountSpecDiscriminatorType.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxapiMountSpecDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "contexthub" => SandboxapiMountSpecDiscriminatorType.Contexthub,
                "gcs" => SandboxapiMountSpecDiscriminatorType.Gcs,
                "git" => SandboxapiMountSpecDiscriminatorType.Git,
                "s3" => SandboxapiMountSpecDiscriminatorType.S3,
                _ => null,
            };
        }
    }
}