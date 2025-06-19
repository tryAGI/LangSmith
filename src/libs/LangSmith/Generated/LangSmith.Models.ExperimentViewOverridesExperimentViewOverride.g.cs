
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentViewOverridesExperimentViewOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_overrides")]
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? ColumnOverrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentViewOverridesExperimentViewOverride" /> class.
        /// </summary>
        /// <param name="columnOverrides"></param>
        /// <param name="createdAt"></param>
        /// <param name="datasetId"></param>
        /// <param name="id"></param>
        /// <param name="modifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentViewOverridesExperimentViewOverride(
            global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? columnOverrides,
            string? createdAt,
            string? datasetId,
            string? id,
            string? modifiedAt)
        {
            this.ColumnOverrides = columnOverrides;
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId;
            this.Id = id;
            this.ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentViewOverridesExperimentViewOverride" /> class.
        /// </summary>
        public ExperimentViewOverridesExperimentViewOverride()
        {
        }
    }
}