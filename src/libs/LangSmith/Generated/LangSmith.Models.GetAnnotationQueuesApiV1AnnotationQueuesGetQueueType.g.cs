
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
        Single,
        /// <summary>
        /// 
        /// </summary>
        Pairwise,
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
                GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Single => "single",
                GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Pairwise => "pairwise",
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
                "single" => GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Single,
                "pairwise" => GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType.Pairwise,
                _ => null,
            };
        }
    }
}