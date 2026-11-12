
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesProxyRuleMatchScheme
    {
        /// <summary>
        ///
        /// </summary>
        Https,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesProxyRuleMatchSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesProxyRuleMatchScheme value)
        {
            return value switch
            {
                SandboxesProxyRuleMatchScheme.Https => "https",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesProxyRuleMatchScheme? ToEnum(string value)
        {
            return value switch
            {
                "https" => SandboxesProxyRuleMatchScheme.Https,
                _ => null,
            };
        }
    }
}