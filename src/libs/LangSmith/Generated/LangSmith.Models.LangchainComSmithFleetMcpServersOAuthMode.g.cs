
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum LangchainComSmithFleetMcpServersOAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        OAuthModeLegacySharedProvider,
        /// <summary>
        /// 
        /// </summary>
        OAuthModePerUserDynamicClient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LangchainComSmithFleetMcpServersOAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LangchainComSmithFleetMcpServersOAuthMode value)
        {
            return value switch
            {
                LangchainComSmithFleetMcpServersOAuthMode.OAuthModeLegacySharedProvider => "legacy_shared_provider",
                LangchainComSmithFleetMcpServersOAuthMode.OAuthModePerUserDynamicClient => "per_user_dynamic_client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LangchainComSmithFleetMcpServersOAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "legacy_shared_provider" => LangchainComSmithFleetMcpServersOAuthMode.OAuthModeLegacySharedProvider,
                "per_user_dynamic_client" => LangchainComSmithFleetMcpServersOAuthMode.OAuthModePerUserDynamicClient,
                _ => null,
            };
        }
    }
}