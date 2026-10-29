
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Credentials is what happens to credential headers the sandbox sent, such as Authorization and Cookie: "strip" (the default) removes them, "redact" keeps each with its value replaced by "redacted" (after an auth scheme such as "Bearer "), and "keep" forwards them unchanged.
    /// </summary>
    public enum SandboxapiProxyRewriteConfigCredentials
    {
        /// <summary>
        /// "strip" (the default) removes them, "redact" keeps each with its value replaced by "redacted" (after an auth scheme such as "Bearer "), and "keep" forwards them unchanged.
        /// </summary>
        Keep,
        /// <summary>
        /// "strip" (the default) removes them, "redact" keeps each with its value replaced by "redacted" (after an auth scheme such as "Bearer "), and "keep" forwards them unchanged.
        /// </summary>
        Redact,
        /// <summary>
        /// "strip" (the default) removes them, "redact" keeps each with its value replaced by "redacted" (after an auth scheme such as "Bearer "), and "keep" forwards them unchanged.
        /// </summary>
        Strip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxapiProxyRewriteConfigCredentialsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxapiProxyRewriteConfigCredentials value)
        {
            return value switch
            {
                SandboxapiProxyRewriteConfigCredentials.Keep => "keep",
                SandboxapiProxyRewriteConfigCredentials.Redact => "redact",
                SandboxapiProxyRewriteConfigCredentials.Strip => "strip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxapiProxyRewriteConfigCredentials? ToEnum(string value)
        {
            return value switch
            {
                "keep" => SandboxapiProxyRewriteConfigCredentials.Keep,
                "redact" => SandboxapiProxyRewriteConfigCredentials.Redact,
                "strip" => SandboxapiProxyRewriteConfigCredentials.Strip,
                _ => null,
            };
        }
    }
}