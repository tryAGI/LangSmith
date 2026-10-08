
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSessionsResolutionsEnvironment
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
    public static class GetSessionsResolutionsEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionsResolutionsEnvironment value)
        {
            return value switch
            {
                GetSessionsResolutionsEnvironment.Development => "DEVELOPMENT",
                GetSessionsResolutionsEnvironment.Local => "LOCAL",
                GetSessionsResolutionsEnvironment.Production => "PRODUCTION",
                GetSessionsResolutionsEnvironment.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionsResolutionsEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "DEVELOPMENT" => GetSessionsResolutionsEnvironment.Development,
                "LOCAL" => GetSessionsResolutionsEnvironment.Local,
                "PRODUCTION" => GetSessionsResolutionsEnvironment.Production,
                "STAGING" => GetSessionsResolutionsEnvironment.Staging,
                _ => null,
            };
        }
    }
}