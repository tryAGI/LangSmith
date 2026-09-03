
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ThreadsSandboxScope
    {
        /// <summary>
        ///
        /// </summary>
        SandboxScopeAgent,
        /// <summary>
        ///
        /// </summary>
        SandboxScopeThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsSandboxScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsSandboxScope value)
        {
            return value switch
            {
                ThreadsSandboxScope.SandboxScopeAgent => "agent",
                ThreadsSandboxScope.SandboxScopeThread => "thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsSandboxScope? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ThreadsSandboxScope.SandboxScopeAgent,
                "thread" => ThreadsSandboxScope.SandboxScopeThread,
                _ => null,
            };
        }
    }
}