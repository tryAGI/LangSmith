
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2
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
    public static class GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2 value)
        {
            return value switch
            {
                GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2.Single => "single",
                GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2.Pairwise => "pairwise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2? ToEnum(string value)
        {
            return value switch
            {
                "single" => GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2.Single,
                "pairwise" => GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2.Pairwise,
                _ => null,
            };
        }
    }
}