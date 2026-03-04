
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueSchemaQueueType
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
    public static class AnnotationQueueSchemaQueueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueSchemaQueueType value)
        {
            return value switch
            {
                AnnotationQueueSchemaQueueType.Single => "single",
                AnnotationQueueSchemaQueueType.Pairwise => "pairwise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueSchemaQueueType? ToEnum(string value)
        {
            return value switch
            {
                "single" => AnnotationQueueSchemaQueueType.Single,
                "pairwise" => AnnotationQueueSchemaQueueType.Pairwise,
                _ => null,
            };
        }
    }
}