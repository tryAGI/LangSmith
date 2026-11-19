
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AgreementState
    {
        /// <summary>
        ///
        /// </summary>
        StateAgreed,
        /// <summary>
        ///
        /// </summary>
        StateDisagreed,
        /// <summary>
        ///
        /// </summary>
        StateNone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgreementStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgreementState value)
        {
            return value switch
            {
                AgreementState.StateAgreed => "agreed",
                AgreementState.StateDisagreed => "disagreed",
                AgreementState.StateNone => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgreementState? ToEnum(string value)
        {
            return value switch
            {
                "agreed" => AgreementState.StateAgreed,
                "disagreed" => AgreementState.StateDisagreed,
                "none" => AgreementState.StateNone,
                _ => null,
            };
        }
    }
}