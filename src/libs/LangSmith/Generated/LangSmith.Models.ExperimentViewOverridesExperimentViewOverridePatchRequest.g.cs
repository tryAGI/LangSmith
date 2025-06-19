
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentViewOverridesExperimentViewOverridePatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride> ColumnOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentViewOverridesExperimentViewOverridePatchRequest" /> class.
        /// </summary>
        /// <param name="columnOverrides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentViewOverridesExperimentViewOverridePatchRequest(
            global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride> columnOverrides)
        {
            this.ColumnOverrides = columnOverrides ?? throw new global::System.ArgumentNullException(nameof(columnOverrides));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentViewOverridesExperimentViewOverridePatchRequest" /> class.
        /// </summary>
        public ExperimentViewOverridesExperimentViewOverridePatchRequest()
        {
        }
    }
}