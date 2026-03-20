
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthzInternalAbacAttributeName
    {
        /// <summary>
        /// 
        /// </summary>
        AbacAttributeNameResourceTagKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthzInternalAbacAttributeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthzInternalAbacAttributeName value)
        {
            return value switch
            {
                AuthzInternalAbacAttributeName.AbacAttributeNameResourceTagKey => "resource_tag_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthzInternalAbacAttributeName? ToEnum(string value)
        {
            return value switch
            {
                "resource_tag_key" => AuthzInternalAbacAttributeName.AbacAttributeNameResourceTagKey,
                _ => null,
            };
        }
    }
}