
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueSchemaWithSizeQueueType
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
    public static class AnnotationQueueSchemaWithSizeQueueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueSchemaWithSizeQueueType value)
        {
            return value switch
            {
                AnnotationQueueSchemaWithSizeQueueType.Single => "single",
                AnnotationQueueSchemaWithSizeQueueType.Pairwise => "pairwise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueSchemaWithSizeQueueType? ToEnum(string value)
        {
            return value switch
            {
                "single" => AnnotationQueueSchemaWithSizeQueueType.Single,
                "pairwise" => AnnotationQueueSchemaWithSizeQueueType.Pairwise,
                _ => null,
            };
        }
    }
}