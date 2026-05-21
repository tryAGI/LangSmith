
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2
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
    public static class PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2 value)
        {
            return value switch
            {
                PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2.ClientSecretBasic => "client_secret_basic",
                PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2.ClientSecretBasic,
                "client_secret_post" => PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2.ClientSecretPost,
                _ => null,
            };
        }
    }
}