
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListRunRulesType
    {
        /// <summary>
        ///
        /// </summary>
        Dataset,
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRunRulesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRunRulesType value)
        {
            return value switch
            {
                ListRunRulesType.Dataset => "DATASET",
                ListRunRulesType.Project => "PROJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRunRulesType? ToEnum(string value)
        {
            return value switch
            {
                "DATASET" => ListRunRulesType.Dataset,
                "PROJECT" => ListRunRulesType.Project,
                _ => null,
            };
        }
    }
}