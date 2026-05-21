
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsAgentPermissionsVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Tenant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsAgentPermissionsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsAgentPermissionsVisibility value)
        {
            return value switch
            {
                AgentsAgentPermissionsVisibility.Tenant => "tenant",
                AgentsAgentPermissionsVisibility.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsAgentPermissionsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "tenant" => AgentsAgentPermissionsVisibility.Tenant,
                "user" => AgentsAgentPermissionsVisibility.User,
                _ => null,
            };
        }
    }
}