
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum AuditLogEnrichmentsSimulation
    {
        /// <summary>
        ///
        /// </summary>
        Check,
        /// <summary>
        ///
        /// </summary>
        Run,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogEnrichmentsSimulationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEnrichmentsSimulation value)
        {
            return value switch
            {
                AuditLogEnrichmentsSimulation.Check => "check",
                AuditLogEnrichmentsSimulation.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEnrichmentsSimulation? ToEnum(string value)
        {
            return value switch
            {
                "check" => AuditLogEnrichmentsSimulation.Check,
                "run" => AuditLogEnrichmentsSimulation.Run,
                _ => null,
            };
        }
    }
}