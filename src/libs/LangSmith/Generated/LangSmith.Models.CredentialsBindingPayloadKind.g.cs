
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum CredentialsBindingPayloadKind
    {
        /// <summary>
        /// 
        /// </summary>
        McpServer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialsBindingPayloadKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialsBindingPayloadKind value)
        {
            return value switch
            {
                CredentialsBindingPayloadKind.McpServer => "mcp_server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialsBindingPayloadKind? ToEnum(string value)
        {
            return value switch
            {
                "mcp_server" => CredentialsBindingPayloadKind.McpServer,
                _ => null,
            };
        }
    }
}