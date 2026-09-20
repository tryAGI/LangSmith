
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// How the port is shared: "token" for a minted service token, or<br/>
    /// "restricted"/"workspace" for LangSmith login.
    /// </summary>
    public enum SandboxesServiceURLGrantResponseAccess
    {
        /// <summary>
        ///
        /// </summary>
        Restricted,
        /// <summary>
        /// "token" for a minted service token, or
        /// </summary>
        Token,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesServiceURLGrantResponseAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesServiceURLGrantResponseAccess value)
        {
            return value switch
            {
                SandboxesServiceURLGrantResponseAccess.Restricted => "restricted",
                SandboxesServiceURLGrantResponseAccess.Token => "token",
                SandboxesServiceURLGrantResponseAccess.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesServiceURLGrantResponseAccess? ToEnum(string value)
        {
            return value switch
            {
                "restricted" => SandboxesServiceURLGrantResponseAccess.Restricted,
                "token" => SandboxesServiceURLGrantResponseAccess.Token,
                "workspace" => SandboxesServiceURLGrantResponseAccess.Workspace,
                _ => null,
            };
        }
    }
}