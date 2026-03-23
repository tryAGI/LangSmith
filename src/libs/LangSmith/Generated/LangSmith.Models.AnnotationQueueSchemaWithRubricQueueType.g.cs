
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueSchemaWithRubricQueueType
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
    public static class AnnotationQueueSchemaWithRubricQueueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueSchemaWithRubricQueueType value)
        {
            return value switch
            {
                AnnotationQueueSchemaWithRubricQueueType.Pairwise => "pairwise",
                AnnotationQueueSchemaWithRubricQueueType.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueSchemaWithRubricQueueType? ToEnum(string value)
        {
            return value switch
            {
                "pairwise" => AnnotationQueueSchemaWithRubricQueueType.Pairwise,
                "single" => AnnotationQueueSchemaWithRubricQueueType.Single,
                _ => null,
            };
        }
    }
}