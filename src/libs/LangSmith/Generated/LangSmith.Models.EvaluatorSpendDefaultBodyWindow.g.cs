
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluatorSpendDefaultBodyWindow
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Hourly,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorSpendDefaultBodyWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorSpendDefaultBodyWindow value)
        {
            return value switch
            {
                EvaluatorSpendDefaultBodyWindow.Daily => "daily",
                EvaluatorSpendDefaultBodyWindow.Hourly => "hourly",
                EvaluatorSpendDefaultBodyWindow.Monthly => "monthly",
                EvaluatorSpendDefaultBodyWindow.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorSpendDefaultBodyWindow? ToEnum(string value)
        {
            return value switch
            {
                "daily" => EvaluatorSpendDefaultBodyWindow.Daily,
                "hourly" => EvaluatorSpendDefaultBodyWindow.Hourly,
                "monthly" => EvaluatorSpendDefaultBodyWindow.Monthly,
                "weekly" => EvaluatorSpendDefaultBodyWindow.Weekly,
                _ => null,
            };
        }
    }
}