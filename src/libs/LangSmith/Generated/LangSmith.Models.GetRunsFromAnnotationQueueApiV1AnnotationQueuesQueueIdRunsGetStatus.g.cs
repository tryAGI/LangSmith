
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus
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
    public static class GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus value)
        {
            return value switch
            {
                GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus.Completed => "completed",
                GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus.NeedsMyReview => "needs_my_review",
                GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus.NeedsOthersReview => "needs_others_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus.Completed,
                "needs_my_review" => GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus.NeedsMyReview,
                "needs_others_review" => GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus.NeedsOthersReview,
                _ => null,
            };
        }
    }
}