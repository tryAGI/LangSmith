
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaygroundSettingsResponseOauthTokenEndpointAuthMethod
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
    public static class PlaygroundSettingsResponseOauthTokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsResponseOauthTokenEndpointAuthMethod value)
        {
            return value switch
            {
                PlaygroundSettingsResponseOauthTokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                PlaygroundSettingsResponseOauthTokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsResponseOauthTokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => PlaygroundSettingsResponseOauthTokenEndpointAuthMethod.ClientSecretBasic,
                "client_secret_post" => PlaygroundSettingsResponseOauthTokenEndpointAuthMethod.ClientSecretPost,
                _ => null,
            };
        }
    }
}