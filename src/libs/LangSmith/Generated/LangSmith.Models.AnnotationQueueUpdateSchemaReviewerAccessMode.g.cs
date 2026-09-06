
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AnnotationQueueUpdateSchemaReviewerAccessMode
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
    public static class AnnotationQueueUpdateSchemaReviewerAccessModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueUpdateSchemaReviewerAccessMode value)
        {
            return value switch
            {
                AnnotationQueueUpdateSchemaReviewerAccessMode.Any => "any",
                AnnotationQueueUpdateSchemaReviewerAccessMode.Assigned => "assigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueUpdateSchemaReviewerAccessMode? ToEnum(string value)
        {
            return value switch
            {
                "any" => AnnotationQueueUpdateSchemaReviewerAccessMode.Any,
                "assigned" => AnnotationQueueUpdateSchemaReviewerAccessMode.Assigned,
                _ => null,
            };
        }
    }
}