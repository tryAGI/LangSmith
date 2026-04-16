
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum LangchainComSmithFleetMcpServersAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthTypeHeaders,
        /// <summary>
        /// 
        /// </summary>
        AuthTypeOAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LangchainComSmithFleetMcpServersAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LangchainComSmithFleetMcpServersAuthType value)
        {
            return value switch
            {
                LangchainComSmithFleetMcpServersAuthType.AuthTypeHeaders => "headers",
                LangchainComSmithFleetMcpServersAuthType.AuthTypeOAuth => "oauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LangchainComSmithFleetMcpServersAuthType? ToEnum(string value)
        {
            return value switch
            {
                "headers" => LangchainComSmithFleetMcpServersAuthType.AuthTypeHeaders,
                "oauth" => LangchainComSmithFleetMcpServersAuthType.AuthTypeOAuth,
                _ => null,
            };
        }
    }
}