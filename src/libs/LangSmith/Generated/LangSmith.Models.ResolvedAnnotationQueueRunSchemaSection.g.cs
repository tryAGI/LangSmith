
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResolvedAnnotationQueueRunSchemaSection
    {
        /// <summary>
        /// 
        /// </summary>
        NeedsMyReview,
        /// <summary>
        /// 
        /// </summary>
        NeedsOthersReview,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolvedAnnotationQueueRunSchemaSectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolvedAnnotationQueueRunSchemaSection value)
        {
            return value switch
            {
                ResolvedAnnotationQueueRunSchemaSection.NeedsMyReview => "needs_my_review",
                ResolvedAnnotationQueueRunSchemaSection.NeedsOthersReview => "needs_others_review",
                ResolvedAnnotationQueueRunSchemaSection.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolvedAnnotationQueueRunSchemaSection? ToEnum(string value)
        {
            return value switch
            {
                "needs_my_review" => ResolvedAnnotationQueueRunSchemaSection.NeedsMyReview,
                "needs_others_review" => ResolvedAnnotationQueueRunSchemaSection.NeedsOthersReview,
                "completed" => ResolvedAnnotationQueueRunSchemaSection.Completed,
                _ => null,
            };
        }
    }
}