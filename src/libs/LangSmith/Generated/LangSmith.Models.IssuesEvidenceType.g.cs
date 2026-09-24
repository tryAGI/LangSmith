
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesEvidenceType
    {
        /// <summary>
        ///
        /// </summary>
        EvidenceTypeSeries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesEvidenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesEvidenceType value)
        {
            return value switch
            {
                IssuesEvidenceType.EvidenceTypeSeries => "series",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesEvidenceType? ToEnum(string value)
        {
            return value switch
            {
                "series" => IssuesEvidenceType.EvidenceTypeSeries,
                _ => null,
            };
        }
    }
}