
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueUpdateSchemaReviewerAccessMode2
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Assigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueUpdateSchemaReviewerAccessMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueUpdateSchemaReviewerAccessMode2 value)
        {
            return value switch
            {
                AnnotationQueueUpdateSchemaReviewerAccessMode2.Any => "any",
                AnnotationQueueUpdateSchemaReviewerAccessMode2.Assigned => "assigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueUpdateSchemaReviewerAccessMode2? ToEnum(string value)
        {
            return value switch
            {
                "any" => AnnotationQueueUpdateSchemaReviewerAccessMode2.Any,
                "assigned" => AnnotationQueueUpdateSchemaReviewerAccessMode2.Assigned,
                _ => null,
            };
        }
    }
}