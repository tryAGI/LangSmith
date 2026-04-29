
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationsAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthTypeAPIKey,
        /// <summary>
        /// 
        /// </summary>
        AuthTypeHeaders,
        /// <summary>
        /// 
        /// </summary>
        AuthTypeNone,
        /// <summary>
        /// 
        /// </summary>
        AuthTypeOAuth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationsAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationsAuthType value)
        {
            return value switch
            {
                IntegrationsAuthType.AuthTypeAPIKey => "api_key",
                IntegrationsAuthType.AuthTypeHeaders => "headers",
                IntegrationsAuthType.AuthTypeNone => "none",
                IntegrationsAuthType.AuthTypeOAuth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationsAuthType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => IntegrationsAuthType.AuthTypeAPIKey,
                "headers" => IntegrationsAuthType.AuthTypeHeaders,
                "none" => IntegrationsAuthType.AuthTypeNone,
                "oauth2" => IntegrationsAuthType.AuthTypeOAuth2,
                _ => null,
            };
        }
    }
}