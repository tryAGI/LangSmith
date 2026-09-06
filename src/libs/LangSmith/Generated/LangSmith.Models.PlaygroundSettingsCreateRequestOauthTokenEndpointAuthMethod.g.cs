
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod
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
    public static class PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod value)
        {
            return value switch
            {
                PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod.ClientSecretBasic,
                "client_secret_post" => PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod.ClientSecretPost,
                _ => null,
            };
        }
    }
}