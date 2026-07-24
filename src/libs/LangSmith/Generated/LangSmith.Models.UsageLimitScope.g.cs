
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Granularity a limit applies to within a tenant.
    /// </summary>
    public enum UsageLimitScope
    {
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitScope value)
        {
            return value switch
            {
                UsageLimitScope.Project => "project",
                UsageLimitScope.User => "user",
                UsageLimitScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitScope? ToEnum(string value)
        {
            return value switch
            {
                "project" => UsageLimitScope.Project,
                "user" => UsageLimitScope.User,
                "workspace" => UsageLimitScope.Workspace,
                _ => null,
            };
        }
    }
}