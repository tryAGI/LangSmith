
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ProductfeedbackCategory
    {
        /// <summary>
        ///
        /// </summary>
        CategoryBug,
        /// <summary>
        ///
        /// </summary>
        CategoryDocumentation,
        /// <summary>
        ///
        /// </summary>
        CategoryFeatureRequest,
        /// <summary>
        ///
        /// </summary>
        CategoryOther,
        /// <summary>
        ///
        /// </summary>
        CategoryUsability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProductfeedbackCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProductfeedbackCategory value)
        {
            return value switch
            {
                ProductfeedbackCategory.CategoryBug => "BUG",
                ProductfeedbackCategory.CategoryDocumentation => "DOCUMENTATION",
                ProductfeedbackCategory.CategoryFeatureRequest => "FEATURE_REQUEST",
                ProductfeedbackCategory.CategoryOther => "OTHER",
                ProductfeedbackCategory.CategoryUsability => "USABILITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProductfeedbackCategory? ToEnum(string value)
        {
            return value switch
            {
                "BUG" => ProductfeedbackCategory.CategoryBug,
                "DOCUMENTATION" => ProductfeedbackCategory.CategoryDocumentation,
                "FEATURE_REQUEST" => ProductfeedbackCategory.CategoryFeatureRequest,
                "OTHER" => ProductfeedbackCategory.CategoryOther,
                "USABILITY" => ProductfeedbackCategory.CategoryUsability,
                _ => null,
            };
        }
    }
}