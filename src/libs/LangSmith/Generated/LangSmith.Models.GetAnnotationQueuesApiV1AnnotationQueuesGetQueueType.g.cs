
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType
    {
        /// <summary>
        ///
        /// </summary>
        Pairwise,
        /// <summary>
        ///
        /// </summary>
        Single,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnnotationQueuesApiV1AnnotationQueuesGetQueueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType value)
        {
            return value switch
            {
                GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Pairwise => "pairwise",
                GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType? ToEnum(string value)
        {
            return value switch
            {
                "pairwise" => GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Pairwise,
                "single" => GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Single,
                _ => null,
            };
        }
    }
}