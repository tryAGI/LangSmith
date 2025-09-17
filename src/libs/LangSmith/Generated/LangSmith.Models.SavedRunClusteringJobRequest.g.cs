
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request to create a run clustering job.
    /// </summary>
    public sealed partial class SavedRunClusteringJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_n_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastNHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int>? Hierarchy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string>? Partitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<double?, int?>? Sample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SummaryPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? AttributeSchemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedRunClusteringJobRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastNHours"></param>
        /// <param name="hierarchy"></param>
        /// <param name="partitions"></param>
        /// <param name="sample"></param>
        /// <param name="summaryPrompt"></param>
        /// <param name="filter"></param>
        /// <param name="attributeSchemas"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SavedRunClusteringJobRequest(
            string name,
            int lastNHours,
            global::System.Collections.Generic.IList<int>? hierarchy,
            global::System.Collections.Generic.Dictionary<string, string>? partitions,
            global::LangSmith.AnyOf<double?, int?>? sample,
            string? summaryPrompt,
            string? filter,
            object? attributeSchemas)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LastNHours = lastNHours;
            this.Hierarchy = hierarchy ?? throw new global::System.ArgumentNullException(nameof(hierarchy));
            this.Partitions = partitions ?? throw new global::System.ArgumentNullException(nameof(partitions));
            this.Sample = sample;
            this.SummaryPrompt = summaryPrompt ?? throw new global::System.ArgumentNullException(nameof(summaryPrompt));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.AttributeSchemas = attributeSchemas ?? throw new global::System.ArgumentNullException(nameof(attributeSchemas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedRunClusteringJobRequest" /> class.
        /// </summary>
        public SavedRunClusteringJobRequest()
        {
        }
    }
}