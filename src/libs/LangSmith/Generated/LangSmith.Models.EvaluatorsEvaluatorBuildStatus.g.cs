
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluatorsEvaluatorBuildStatus
    {
        /// <summary>
        ///
        /// </summary>
        EvaluatorBuildStatusBuilding,
        /// <summary>
        ///
        /// </summary>
        EvaluatorBuildStatusEnqueued,
        /// <summary>
        ///
        /// </summary>
        EvaluatorBuildStatusFailed,
        /// <summary>
        ///
        /// </summary>
        EvaluatorBuildStatusReady,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluatorsEvaluatorBuildStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluatorsEvaluatorBuildStatus value)
        {
            return value switch
            {
                EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusBuilding => "BUILDING",
                EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusEnqueued => "ENQUEUED",
                EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusFailed => "FAILED",
                EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusReady => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluatorsEvaluatorBuildStatus? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusBuilding,
                "ENQUEUED" => EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusEnqueued,
                "FAILED" => EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusFailed,
                "READY" => EvaluatorsEvaluatorBuildStatus.EvaluatorBuildStatusReady,
                _ => null,
            };
        }
    }
}