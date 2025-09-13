
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response to get a specific cluster job for a session.
    /// </summary>
    public sealed partial class GetRunClusteringJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        public global::System.Collections.Generic.IList<int>? Shape { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.RunCluster> Clusters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRunClusteringJobResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="metadata"></param>
        /// <param name="shape"></param>
        /// <param name="error"></param>
        /// <param name="clusters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRunClusteringJobResponse(
            global::System.Guid id,
            string name,
            string status,
            global::System.Collections.Generic.IList<global::LangSmith.RunCluster> clusters,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            object? metadata,
            global::System.Collections.Generic.IList<int>? shape,
            string? error)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Clusters = clusters ?? throw new global::System.ArgumentNullException(nameof(clusters));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Metadata = metadata;
            this.Shape = shape;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRunClusteringJobResponse" /> class.
        /// </summary>
        public GetRunClusteringJobResponse()
        {
        }
    }
}