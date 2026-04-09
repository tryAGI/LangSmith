
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationsIntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationTypeCustom,
        /// <summary>
        /// 
        /// </summary>
        IntegrationTypeManaged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationsIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationsIntegrationType value)
        {
            return value switch
            {
                IntegrationsIntegrationType.IntegrationTypeCustom => "CUSTOM",
                IntegrationsIntegrationType.IntegrationTypeManaged => "MANAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationsIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => IntegrationsIntegrationType.IntegrationTypeCustom,
                "MANAGED" => IntegrationsIntegrationType.IntegrationTypeManaged,
                _ => null,
            };
        }
    }
}