
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Access echoes the enabled LangSmith login level ("restricted"/"workspace"); omitted in token mode.
    /// </summary>
    public enum SandboxesServiceURLResponseAccess
    {
        /// <summary>
        ///
        /// </summary>
        Restricted,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesServiceURLResponseAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesServiceURLResponseAccess value)
        {
            return value switch
            {
                SandboxesServiceURLResponseAccess.Restricted => "restricted",
                SandboxesServiceURLResponseAccess.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesServiceURLResponseAccess? ToEnum(string value)
        {
            return value switch
            {
                "restricted" => SandboxesServiceURLResponseAccess.Restricted,
                "workspace" => SandboxesServiceURLResponseAccess.Workspace,
                _ => null,
            };
        }
    }
}