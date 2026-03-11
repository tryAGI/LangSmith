
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A single cluster of runs.
    /// </summary>
    public sealed partial class RunCluster
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public global::System.Guid? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Level { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_name")]
        public string? ParentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int NumRuns { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public object? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunCluster" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentId"></param>
        /// <param name="level"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="parentName"></param>
        /// <param name="numRuns"></param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunCluster(
            global::System.Guid id,
            int level,
            string name,
            string description,
            int numRuns,
            global::System.Guid? parentId,
            string? parentName,
            object? stats)
        {
            this.Id = id;
            this.Level = level;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.NumRuns = numRuns;
            this.ParentId = parentId;
            this.ParentName = parentName;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunCluster" /> class.
        /// </summary>
        public RunCluster()
        {
        }
    }
}