
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackFormulaAggregationType
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
    public static class FeedbackFormulaAggregationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackFormulaAggregationType value)
        {
            return value switch
            {
                FeedbackFormulaAggregationType.Sum => "sum",
                FeedbackFormulaAggregationType.Avg => "avg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackFormulaAggregationType? ToEnum(string value)
        {
            return value switch
            {
                "sum" => FeedbackFormulaAggregationType.Sum,
                "avg" => FeedbackFormulaAggregationType.Avg,
                _ => null,
            };
        }
    }
}