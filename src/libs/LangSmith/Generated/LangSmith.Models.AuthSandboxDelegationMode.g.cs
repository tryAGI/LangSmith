
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthSandboxDelegationMode
    {
        /// <summary>
        ///
        /// </summary>
        SandboxDelegationModeExplicit,
        /// <summary>
        ///
        /// </summary>
        SandboxDelegationModeInherit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthSandboxDelegationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthSandboxDelegationMode value)
        {
            return value switch
            {
                AuthSandboxDelegationMode.SandboxDelegationModeExplicit => "EXPLICIT",
                AuthSandboxDelegationMode.SandboxDelegationModeInherit => "INHERIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthSandboxDelegationMode? ToEnum(string value)
        {
            return value switch
            {
                "EXPLICIT" => AuthSandboxDelegationMode.SandboxDelegationModeExplicit,
                "INHERIT" => AuthSandboxDelegationMode.SandboxDelegationModeInherit,
                _ => null,
            };
        }
    }
}