
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListSessionsV2TypeItem
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
    public static class ListSessionsV2TypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSessionsV2TypeItem value)
        {
            return value switch
            {
                ListSessionsV2TypeItem.Agent => "AGENT",
                ListSessionsV2TypeItem.Experiment => "EXPERIMENT",
                ListSessionsV2TypeItem.Project => "PROJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSessionsV2TypeItem? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => ListSessionsV2TypeItem.Agent,
                "EXPERIMENT" => ListSessionsV2TypeItem.Experiment,
                "PROJECT" => ListSessionsV2TypeItem.Project,
                _ => null,
            };
        }
    }
}