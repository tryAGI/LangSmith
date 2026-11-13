
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum OrgDefaultApplyTo
    {
        /// <summary>
        ///
        /// </summary>
        InheritedOrUnset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgDefaultApplyToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgDefaultApplyTo value)
        {
            return value switch
            {
                OrgDefaultApplyTo.InheritedOrUnset => "INHERITED_OR_UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgDefaultApplyTo? ToEnum(string value)
        {
            return value switch
            {
                "INHERITED_OR_UNSET" => OrgDefaultApplyTo.InheritedOrUnset,
                _ => null,
            };
        }
    }
}