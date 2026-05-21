
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum McptoolsMCPErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        MCPErrorCodeAuthFailed,
        /// <summary>
        /// 
        /// </summary>
        MCPErrorCodeInvalidResponse,
        /// <summary>
        /// 
        /// </summary>
        MCPErrorCodeUnreachable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McptoolsMCPErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McptoolsMCPErrorCode value)
        {
            return value switch
            {
                McptoolsMCPErrorCode.MCPErrorCodeAuthFailed => "auth_failed",
                McptoolsMCPErrorCode.MCPErrorCodeInvalidResponse => "invalid_response",
                McptoolsMCPErrorCode.MCPErrorCodeUnreachable => "unreachable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McptoolsMCPErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "auth_failed" => McptoolsMCPErrorCode.MCPErrorCodeAuthFailed,
                "invalid_response" => McptoolsMCPErrorCode.MCPErrorCodeInvalidResponse,
                "unreachable" => McptoolsMCPErrorCode.MCPErrorCodeUnreachable,
                _ => null,
            };
        }
    }
}