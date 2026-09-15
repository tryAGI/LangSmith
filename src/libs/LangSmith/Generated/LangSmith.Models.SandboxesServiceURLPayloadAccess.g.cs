
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Access selects the login mode, mutually exclusive with the minted token.<br/>
    /// Omit the field for token mode: mint a short-lived service token (default).<br/>
    ///   "restricted" — LangSmith login: any user with SandboxesRead on the sandbox.<br/>
    ///   "workspace"  — LangSmith login: any member of the owning workspace.<br/>
    ///   "off"        — remove an existing LangSmith login grant and mint a token.<br/>
    /// A LangSmith login grant is durable; token mode is refused (409) while one exists.
    /// </summary>
    public enum SandboxesServiceURLPayloadAccess
    {
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        /// any user with SandboxesRead on the sandbox.
        /// </summary>
        Restricted,
        /// <summary>
        /// any member of the owning workspace.
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesServiceURLPayloadAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesServiceURLPayloadAccess value)
        {
            return value switch
            {
                SandboxesServiceURLPayloadAccess.Off => "off",
                SandboxesServiceURLPayloadAccess.Restricted => "restricted",
                SandboxesServiceURLPayloadAccess.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesServiceURLPayloadAccess? ToEnum(string value)
        {
            return value switch
            {
                "off" => SandboxesServiceURLPayloadAccess.Off,
                "restricted" => SandboxesServiceURLPayloadAccess.Restricted,
                "workspace" => SandboxesServiceURLPayloadAccess.Workspace,
                _ => null,
            };
        }
    }
}