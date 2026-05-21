
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        /// 
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2 value)
        {
            return value switch
            {
                PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2.ClientSecretBasic => "client_secret_basic",
                PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2.ClientSecretBasic,
                "client_secret_post" => PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2.ClientSecretPost,
                _ => null,
            };
        }
    }
}