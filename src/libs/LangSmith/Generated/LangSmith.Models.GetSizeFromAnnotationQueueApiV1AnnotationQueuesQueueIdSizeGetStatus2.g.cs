
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        NeedsMyReview,
        /// <summary>
        /// 
        /// </summary>
        NeedsOthersReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2 value)
        {
            return value switch
            {
                GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2.Completed => "completed",
                GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2.NeedsMyReview => "needs_my_review",
                GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2.NeedsOthersReview => "needs_others_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2.Completed,
                "needs_my_review" => GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2.NeedsMyReview,
                "needs_others_review" => GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2.NeedsOthersReview,
                _ => null,
            };
        }
    }
}