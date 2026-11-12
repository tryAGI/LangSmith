
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum RulesAlertSeverity
    {
        /// <summary>
        ///
        /// </summary>
        Critical,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Info,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RulesAlertSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RulesAlertSeverity value)
        {
            return value switch
            {
                RulesAlertSeverity.Critical => "CRITICAL",
                RulesAlertSeverity.Error => "ERROR",
                RulesAlertSeverity.Info => "INFO",
                RulesAlertSeverity.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RulesAlertSeverity? ToEnum(string value)
        {
            return value switch
            {
                "CRITICAL" => RulesAlertSeverity.Critical,
                "ERROR" => RulesAlertSeverity.Error,
                "INFO" => RulesAlertSeverity.Info,
                "WARNING" => RulesAlertSeverity.Warning,
                _ => null,
            };
        }
    }
}