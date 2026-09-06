
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod
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
    public static class PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod value)
        {
            return value switch
            {
                PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod.ClientSecretBasic => "client_secret_basic",
                PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod.ClientSecretBasic,
                "client_secret_post" => PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod.ClientSecretPost,
                _ => null,
            };
        }
    }
}