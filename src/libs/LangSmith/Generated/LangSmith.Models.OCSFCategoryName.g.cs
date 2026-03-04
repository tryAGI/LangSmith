
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF category names.
    /// </summary>
    public enum OCSFCategoryName
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationActivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OCSFCategoryNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OCSFCategoryName value)
        {
            return value switch
            {
                OCSFCategoryName.ApplicationActivity => "Application Activity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OCSFCategoryName? ToEnum(string value)
        {
            return value switch
            {
                "Application Activity" => OCSFCategoryName.ApplicationActivity,
                _ => null,
            };
        }
    }
}