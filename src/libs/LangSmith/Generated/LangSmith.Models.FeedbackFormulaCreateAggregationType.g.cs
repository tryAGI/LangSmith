
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
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Sum,
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
                FeedbackFormulaCreateAggregationType.Avg => "avg",
                FeedbackFormulaCreateAggregationType.Sum => "sum",
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
                "avg" => FeedbackFormulaCreateAggregationType.Avg,
                "sum" => FeedbackFormulaCreateAggregationType.Sum,
                _ => null,
            };
        }
    }
}