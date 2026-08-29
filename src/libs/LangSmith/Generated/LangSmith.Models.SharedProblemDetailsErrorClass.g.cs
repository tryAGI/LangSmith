
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// ErrorClass is a LangSmith extension sub-categorizing a status code.<br/>
    /// Additional values require expanding this enum and adding a oneOf<br/>
    /// discriminator on Details to keep the class↔details contract typed.
    /// </summary>
    public enum SharedProblemDetailsErrorClass
    {
        /// <summary>
        ///
        /// </summary>
        ParseFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharedProblemDetailsErrorClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharedProblemDetailsErrorClass value)
        {
            return value switch
            {
                SharedProblemDetailsErrorClass.ParseFailure => "PARSE_FAILURE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharedProblemDetailsErrorClass? ToEnum(string value)
        {
            return value switch
            {
                "PARSE_FAILURE" => SharedProblemDetailsErrorClass.ParseFailure,
                _ => null,
            };
        }
    }
}