
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsAgentPermissionsIdentity
    {
        /// <summary>
        /// 
        /// </summary>
        Personal,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsAgentPermissionsIdentityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsAgentPermissionsIdentity value)
        {
            return value switch
            {
                AgentsAgentPermissionsIdentity.Personal => "personal",
                AgentsAgentPermissionsIdentity.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsAgentPermissionsIdentity? ToEnum(string value)
        {
            return value switch
            {
                "personal" => AgentsAgentPermissionsIdentity.Personal,
                "shared" => AgentsAgentPermissionsIdentity.Shared,
                _ => null,
            };
        }
    }
}