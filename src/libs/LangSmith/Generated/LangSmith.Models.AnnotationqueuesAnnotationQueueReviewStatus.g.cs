
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AnnotationqueuesAnnotationQueueReviewStatus
    {
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueReviewStatusCompleted,
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueReviewStatusViewed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationqueuesAnnotationQueueReviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationqueuesAnnotationQueueReviewStatus value)
        {
            return value switch
            {
                AnnotationqueuesAnnotationQueueReviewStatus.AnnotationQueueReviewStatusCompleted => "completed",
                AnnotationqueuesAnnotationQueueReviewStatus.AnnotationQueueReviewStatusViewed => "viewed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationqueuesAnnotationQueueReviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AnnotationqueuesAnnotationQueueReviewStatus.AnnotationQueueReviewStatusCompleted,
                "viewed" => AnnotationqueuesAnnotationQueueReviewStatus.AnnotationQueueReviewStatusViewed,
                _ => null,
            };
        }
    }
}