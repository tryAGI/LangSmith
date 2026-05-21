
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2
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
    public static class PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2 value)
        {
            return value switch
            {
                PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2.ClientSecretBasic => "client_secret_basic",
                PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2.ClientSecretBasic,
                "client_secret_post" => PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2.ClientSecretPost,
                _ => null,
            };
        }
    }
}