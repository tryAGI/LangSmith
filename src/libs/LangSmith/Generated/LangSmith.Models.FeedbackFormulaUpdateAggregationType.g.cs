
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackFormulaUpdateAggregationType
    {
        /// <summary>
        /// 
        /// </summary>
        Sum,
        /// <summary>
        /// 
        /// </summary>
        Avg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackFormulaUpdateAggregationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackFormulaUpdateAggregationType value)
        {
            return value switch
            {
                FeedbackFormulaUpdateAggregationType.Sum => "sum",
                FeedbackFormulaUpdateAggregationType.Avg => "avg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackFormulaUpdateAggregationType? ToEnum(string value)
        {
            return value switch
            {
                "sum" => FeedbackFormulaUpdateAggregationType.Sum,
                "avg" => FeedbackFormulaUpdateAggregationType.Avg,
                _ => null,
            };
        }
    }
}