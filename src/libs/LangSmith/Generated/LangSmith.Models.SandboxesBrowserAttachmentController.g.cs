
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Controller is "agent" while the attached sandbox drives the window and<br/>
    /// "user" while a person has taken it over.
    /// </summary>
    public enum SandboxesBrowserAttachmentController
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
    public static class SandboxesBrowserAttachmentControllerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesBrowserAttachmentController value)
        {
            return value switch
            {
                SandboxesBrowserAttachmentController.Agent => "agent",
                SandboxesBrowserAttachmentController.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesBrowserAttachmentController? ToEnum(string value)
        {
            return value switch
            {
                "agent" => SandboxesBrowserAttachmentController.Agent,
                "user" => SandboxesBrowserAttachmentController.User,
                _ => null,
            };
        }
    }
}