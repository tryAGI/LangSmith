
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AnnotationqueuesAnnotationQueueItemListStatus
    {
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueItemStatusArchived,
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueItemStatusNeedsMyReview,
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueItemStatusNeedsOthersReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationqueuesAnnotationQueueItemListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationqueuesAnnotationQueueItemListStatus value)
        {
            return value switch
            {
                AnnotationqueuesAnnotationQueueItemListStatus.AnnotationQueueItemStatusArchived => "archived",
                AnnotationqueuesAnnotationQueueItemListStatus.AnnotationQueueItemStatusNeedsMyReview => "needs_my_review",
                AnnotationqueuesAnnotationQueueItemListStatus.AnnotationQueueItemStatusNeedsOthersReview => "needs_others_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationqueuesAnnotationQueueItemListStatus? ToEnum(string value)
        {
            return value switch
            {
                "archived" => AnnotationqueuesAnnotationQueueItemListStatus.AnnotationQueueItemStatusArchived,
                "needs_my_review" => AnnotationqueuesAnnotationQueueItemListStatus.AnnotationQueueItemStatusNeedsMyReview,
                "needs_others_review" => AnnotationqueuesAnnotationQueueItemListStatus.AnnotationQueueItemStatusNeedsOthersReview,
                _ => null,
            };
        }
    }
}