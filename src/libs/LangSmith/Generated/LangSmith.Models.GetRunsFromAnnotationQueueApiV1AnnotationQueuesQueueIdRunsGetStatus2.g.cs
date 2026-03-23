
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2
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
    public static class GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2 value)
        {
            return value switch
            {
                GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2.Completed => "completed",
                GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2.NeedsMyReview => "needs_my_review",
                GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2.NeedsOthersReview => "needs_others_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2.Completed,
                "needs_my_review" => GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2.NeedsMyReview,
                "needs_others_review" => GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2.NeedsOthersReview,
                _ => null,
            };
        }
    }
}