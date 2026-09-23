
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorsManagedCodeEvaluatorKey
    {
        /// <summary>
        ///
        /// </summary>
        ManagedCodeEvaluatorKeyVoiceMetrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorsManagedCodeEvaluatorKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorsManagedCodeEvaluatorKey value)
        {
            return value switch
            {
                EvaluatorsManagedCodeEvaluatorKey.ManagedCodeEvaluatorKeyVoiceMetrics => "voice_metrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorsManagedCodeEvaluatorKey? ToEnum(string value)
        {
            return value switch
            {
                "voice_metrics" => EvaluatorsManagedCodeEvaluatorKey.ManagedCodeEvaluatorKeyVoiceMetrics,
                _ => null,
            };
        }
    }
}