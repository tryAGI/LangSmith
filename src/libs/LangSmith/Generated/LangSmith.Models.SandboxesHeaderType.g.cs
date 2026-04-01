
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxesHeaderType
    {
        /// <summary>
        /// 
        /// </summary>
        HeaderTypeOpaque,
        /// <summary>
        /// 
        /// </summary>
        HeaderTypePlaintext,
        /// <summary>
        /// 
        /// </summary>
        HeaderTypeWorkspaceSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesHeaderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesHeaderType value)
        {
            return value switch
            {
                SandboxesHeaderType.HeaderTypeOpaque => "opaque",
                SandboxesHeaderType.HeaderTypePlaintext => "plaintext",
                SandboxesHeaderType.HeaderTypeWorkspaceSecret => "workspace_secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesHeaderType? ToEnum(string value)
        {
            return value switch
            {
                "opaque" => SandboxesHeaderType.HeaderTypeOpaque,
                "plaintext" => SandboxesHeaderType.HeaderTypePlaintext,
                "workspace_secret" => SandboxesHeaderType.HeaderTypeWorkspaceSecret,
                _ => null,
            };
        }
    }
}