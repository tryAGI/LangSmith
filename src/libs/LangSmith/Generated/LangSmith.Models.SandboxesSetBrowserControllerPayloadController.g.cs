
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Controller is "user" to give the window to a person, or "agent" to give<br/>
    /// it back to the attached sandbox.
    /// </summary>
    public enum SandboxesSetBrowserControllerPayloadController
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesSetBrowserControllerPayloadControllerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesSetBrowserControllerPayloadController value)
        {
            return value switch
            {
                SandboxesSetBrowserControllerPayloadController.Agent => "agent",
                SandboxesSetBrowserControllerPayloadController.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesSetBrowserControllerPayloadController? ToEnum(string value)
        {
            return value switch
            {
                "agent" => SandboxesSetBrowserControllerPayloadController.Agent,
                "user" => SandboxesSetBrowserControllerPayloadController.User,
                _ => null,
            };
        }
    }
}