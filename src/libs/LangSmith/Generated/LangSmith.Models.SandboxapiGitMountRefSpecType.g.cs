
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxapiGitMountRefSpecType
    {
        /// <summary>
        /// 
        /// </summary>
        Branch,
        /// <summary>
        /// 
        /// </summary>
        Tag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxapiGitMountRefSpecTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxapiGitMountRefSpecType value)
        {
            return value switch
            {
                SandboxapiGitMountRefSpecType.Branch => "branch",
                SandboxapiGitMountRefSpecType.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxapiGitMountRefSpecType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => SandboxapiGitMountRefSpecType.Branch,
                "tag" => SandboxapiGitMountRefSpecType.Tag,
                _ => null,
            };
        }
    }
}