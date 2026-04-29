
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationsTransport
    {
        /// <summary>
        /// 
        /// </summary>
        TransportMCPHTTP,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationsTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationsTransport value)
        {
            return value switch
            {
                IntegrationsTransport.TransportMCPHTTP => "mcp_http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationsTransport? ToEnum(string value)
        {
            return value switch
            {
                "mcp_http" => IntegrationsTransport.TransportMCPHTTP,
                _ => null,
            };
        }
    }
}