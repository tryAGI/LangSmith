
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Type identifies a tracing project, Agent tracing project, or experiment.
    /// </summary>
    public enum TracerSessionsCreateSessionRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Experiment,
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TracerSessionsCreateSessionRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracerSessionsCreateSessionRequestType value)
        {
            return value switch
            {
                TracerSessionsCreateSessionRequestType.Agent => "AGENT",
                TracerSessionsCreateSessionRequestType.Experiment => "EXPERIMENT",
                TracerSessionsCreateSessionRequestType.Project => "PROJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracerSessionsCreateSessionRequestType? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => TracerSessionsCreateSessionRequestType.Agent,
                "EXPERIMENT" => TracerSessionsCreateSessionRequestType.Experiment,
                "PROJECT" => TracerSessionsCreateSessionRequestType.Project,
                _ => null,
            };
        }
    }
}