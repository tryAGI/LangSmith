
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
        Scim,
        /// <summary>
        /// 
        /// </summary>
        Saml_jit,
        /// <summary>
        /// 
        /// </summary>
        Bootstrap,
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
                ProvisioningMethod.Scim => "scim",
                ProvisioningMethod.Saml_jit => "saml:jit",
                ProvisioningMethod.Bootstrap => "bootstrap",
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
                "scim" => ProvisioningMethod.Scim,
                "saml:jit" => ProvisioningMethod.Saml_jit,
                "bootstrap" => ProvisioningMethod.Bootstrap,
                _ => null,
            };
        }
    }
}