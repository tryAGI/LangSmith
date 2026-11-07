
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `PROJECT` for a tracing project, `AGENT` for an Agent's tracing project, or `EXPERIMENT` for an evaluation run against a dataset.
    /// </summary>
    public enum SessionType
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
    public static class SessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionType value)
        {
            return value switch
            {
                SessionType.Agent => "AGENT",
                SessionType.Experiment => "EXPERIMENT",
                SessionType.Project => "PROJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionType? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => SessionType.Agent,
                "EXPERIMENT" => SessionType.Experiment,
                "PROJECT" => SessionType.Project,
                _ => null,
            };
        }
    }
}