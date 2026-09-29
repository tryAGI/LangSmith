
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum FeedbackCreateSchemaAgentEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Local,
        /// <summary>
        ///
        /// </summary>
        Production,
        /// <summary>
        ///
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackCreateSchemaAgentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackCreateSchemaAgentEnvironment value)
        {
            return value switch
            {
                FeedbackCreateSchemaAgentEnvironment.Development => "DEVELOPMENT",
                FeedbackCreateSchemaAgentEnvironment.Local => "LOCAL",
                FeedbackCreateSchemaAgentEnvironment.Production => "PRODUCTION",
                FeedbackCreateSchemaAgentEnvironment.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackCreateSchemaAgentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "DEVELOPMENT" => FeedbackCreateSchemaAgentEnvironment.Development,
                "LOCAL" => FeedbackCreateSchemaAgentEnvironment.Local,
                "PRODUCTION" => FeedbackCreateSchemaAgentEnvironment.Production,
                "STAGING" => FeedbackCreateSchemaAgentEnvironment.Staging,
                _ => null,
            };
        }
    }
}