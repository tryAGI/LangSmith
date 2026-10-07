
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SSOProviderType
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
        /// <summary>
        ///
        /// </summary>
        Saml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SSOProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SSOProviderType value)
        {
            return value switch
            {
                SSOProviderType.Oidc => "oidc",
                SSOProviderType.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SSOProviderType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => SSOProviderType.Oidc,
                "saml" => SSOProviderType.Saml,
                _ => null,
            };
        }
    }
}