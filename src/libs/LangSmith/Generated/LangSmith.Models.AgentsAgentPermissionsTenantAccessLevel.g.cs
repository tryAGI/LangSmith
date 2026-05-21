
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsAgentPermissionsTenantAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Run,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsAgentPermissionsTenantAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsAgentPermissionsTenantAccessLevel value)
        {
            return value switch
            {
                AgentsAgentPermissionsTenantAccessLevel.Read => "read",
                AgentsAgentPermissionsTenantAccessLevel.Run => "run",
                AgentsAgentPermissionsTenantAccessLevel.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsAgentPermissionsTenantAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "read" => AgentsAgentPermissionsTenantAccessLevel.Read,
                "run" => AgentsAgentPermissionsTenantAccessLevel.Run,
                "write" => AgentsAgentPermissionsTenantAccessLevel.Write,
                _ => null,
            };
        }
    }
}