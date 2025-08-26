
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackFormulaCreateAggregationType
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
    public static class FeedbackFormulaCreateAggregationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackFormulaCreateAggregationType value)
        {
            return value switch
            {
                FeedbackFormulaCreateAggregationType.Sum => "sum",
                FeedbackFormulaCreateAggregationType.Avg => "avg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackFormulaCreateAggregationType? ToEnum(string value)
        {
            return value switch
            {
                "sum" => FeedbackFormulaCreateAggregationType.Sum,
                "avg" => FeedbackFormulaCreateAggregationType.Avg,
                _ => null,
            };
        }
    }
}