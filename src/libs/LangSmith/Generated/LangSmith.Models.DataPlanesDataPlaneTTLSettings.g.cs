
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesDataPlaneTTLSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LongDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShortDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneTTLSettings" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="longDays"></param>
        /// <param name="shortDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneTTLSettings(
            bool enabled,
            int longDays,
            int shortDays)
        {
            this.Enabled = enabled;
            this.LongDays = longDays;
            this.ShortDays = shortDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneTTLSettings" /> class.
        /// </summary>
        public DataPlanesDataPlaneTTLSettings()
        {
        }

    }
}