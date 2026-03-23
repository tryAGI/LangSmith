
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProvisioningMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Bootstrap,
        /// <summary>
        /// 
        /// </summary>
        Saml_jit,
        /// <summary>
        /// 
        /// </summary>
        Scim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvisioningMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvisioningMethod value)
        {
            return value switch
            {
                ProvisioningMethod.Bootstrap => "bootstrap",
                ProvisioningMethod.Saml_jit => "saml:jit",
                ProvisioningMethod.Scim => "scim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvisioningMethod? ToEnum(string value)
        {
            return value switch
            {
                "bootstrap" => ProvisioningMethod.Bootstrap,
                "saml:jit" => ProvisioningMethod.Saml_jit,
                "scim" => ProvisioningMethod.Scim,
                _ => null,
            };
        }
    }
}