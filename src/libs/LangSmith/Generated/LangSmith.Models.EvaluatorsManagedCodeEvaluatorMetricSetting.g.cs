
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EvaluatorsManagedCodeEvaluatorMetricSetting
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsManagedCodeEvaluatorMetricSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="keyName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsManagedCodeEvaluatorMetricSetting(
            bool? isEnabled,
            string? keyName)
        {
            this.IsEnabled = isEnabled;
            this.KeyName = keyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsManagedCodeEvaluatorMetricSetting" /> class.
        /// </summary>
        public EvaluatorsManagedCodeEvaluatorMetricSetting()
        {
        }

    }
}