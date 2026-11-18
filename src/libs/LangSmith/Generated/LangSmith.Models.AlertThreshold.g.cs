
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A usage level that sends an alert when reached.
    /// </summary>
    public sealed partial class AlertThreshold
    {
        /// <summary>
        /// `PERCENT` of the limit, or an absolute `COUNT` in the limit's unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AlertThresholdKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AlertThresholdKind Kind { get; set; }

        /// <summary>
        /// 1-100 for `PERCENT`; a positive number for `COUNT`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertThreshold" /> class.
        /// </summary>
        /// <param name="kind">
        /// `PERCENT` of the limit, or an absolute `COUNT` in the limit's unit.
        /// </param>
        /// <param name="value">
        /// 1-100 for `PERCENT`; a positive number for `COUNT`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertThreshold(
            global::LangSmith.AlertThresholdKind kind,
            int value)
        {
            this.Kind = kind;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertThreshold" /> class.
        /// </summary>
        public AlertThreshold()
        {
        }

    }
}