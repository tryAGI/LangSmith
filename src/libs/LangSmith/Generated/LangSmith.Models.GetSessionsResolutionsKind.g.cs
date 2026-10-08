
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSessionsResolutionsKind
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Evaluator,
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSessionsResolutionsKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionsResolutionsKind value)
        {
            return value switch
            {
                GetSessionsResolutionsKind.Agent => "AGENT",
                GetSessionsResolutionsKind.Evaluator => "EVALUATOR",
                GetSessionsResolutionsKind.Experiment => "EXPERIMENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionsResolutionsKind? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => GetSessionsResolutionsKind.Agent,
                "EVALUATOR" => GetSessionsResolutionsKind.Evaluator,
                "EXPERIMENT" => GetSessionsResolutionsKind.Experiment,
                _ => null,
            };
        }
    }
}