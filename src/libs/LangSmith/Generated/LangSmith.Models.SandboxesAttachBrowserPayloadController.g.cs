
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Controller is who drives a window opened with no sandbox: "user"<br/>
    /// (default) for a person in the live view, or "agent" for a client that<br/>
    /// drives it over api_cdp_url. A sandbox's window always starts with<br/>
    /// "agent".
    /// </summary>
    public enum SandboxesAttachBrowserPayloadController
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        /// "user"
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesAttachBrowserPayloadControllerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesAttachBrowserPayloadController value)
        {
            return value switch
            {
                SandboxesAttachBrowserPayloadController.Agent => "agent",
                SandboxesAttachBrowserPayloadController.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesAttachBrowserPayloadController? ToEnum(string value)
        {
            return value switch
            {
                "agent" => SandboxesAttachBrowserPayloadController.Agent,
                "user" => SandboxesAttachBrowserPayloadController.User,
                _ => null,
            };
        }
    }
}