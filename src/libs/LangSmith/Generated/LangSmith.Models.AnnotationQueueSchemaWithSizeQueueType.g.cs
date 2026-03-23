
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
        Pairwise,
        /// <summary>
        /// 
        /// </summary>
        Single,
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
                AnnotationQueueSchemaWithSizeQueueType.Pairwise => "pairwise",
                AnnotationQueueSchemaWithSizeQueueType.Single => "single",
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
                "pairwise" => AnnotationQueueSchemaWithSizeQueueType.Pairwise,
                "single" => AnnotationQueueSchemaWithSizeQueueType.Single,
                _ => null,
            };
        }
    }
}