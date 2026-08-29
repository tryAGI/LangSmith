
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlatformAnnotationQueuesItemsStatus
    {
        /// <summary>
        /// needs_my_review, needs_others_review, or archived
        /// </summary>
        Archived,
        /// <summary>
        /// needs_my_review, needs_others_review, or archived
        /// </summary>
        NeedsMyReview,
        /// <summary>
        /// needs_my_review, needs_others_review, or archived
        /// </summary>
        NeedsOthersReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformAnnotationQueuesItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformAnnotationQueuesItemsStatus value)
        {
            return value switch
            {
                GetPlatformAnnotationQueuesItemsStatus.Archived => "archived",
                GetPlatformAnnotationQueuesItemsStatus.NeedsMyReview => "needs_my_review",
                GetPlatformAnnotationQueuesItemsStatus.NeedsOthersReview => "needs_others_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformAnnotationQueuesItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GetPlatformAnnotationQueuesItemsStatus.Archived,
                "needs_my_review" => GetPlatformAnnotationQueuesItemsStatus.NeedsMyReview,
                "needs_others_review" => GetPlatformAnnotationQueuesItemsStatus.NeedsOthersReview,
                _ => null,
            };
        }
    }
}