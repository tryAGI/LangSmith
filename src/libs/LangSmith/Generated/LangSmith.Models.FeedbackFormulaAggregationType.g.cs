
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
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Sum,
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
                FeedbackFormulaAggregationType.Avg => "avg",
                FeedbackFormulaAggregationType.Sum => "sum",
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
                "avg" => FeedbackFormulaAggregationType.Avg,
                "sum" => FeedbackFormulaAggregationType.Sum,
                _ => null,
            };
        }
    }
}