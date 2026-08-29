
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AnnotationqueuesAnnotationQueueItemType
    {
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueItemTypeRun,
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueItemTypeThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationqueuesAnnotationQueueItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationqueuesAnnotationQueueItemType value)
        {
            return value switch
            {
                AnnotationqueuesAnnotationQueueItemType.AnnotationQueueItemTypeRun => "RUN",
                AnnotationqueuesAnnotationQueueItemType.AnnotationQueueItemTypeThread => "THREAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationqueuesAnnotationQueueItemType? ToEnum(string value)
        {
            return value switch
            {
                "RUN" => AnnotationqueuesAnnotationQueueItemType.AnnotationQueueItemTypeRun,
                "THREAD" => AnnotationqueuesAnnotationQueueItemType.AnnotationQueueItemTypeThread,
                _ => null,
            };
        }
    }
}