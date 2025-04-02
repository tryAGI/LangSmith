
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunsSearchCursor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RunsSearchCursorDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RunsSearchCursorDirection Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsSearchCursor" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="id"></param>
        /// <param name="direction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsSearchCursor(
            string startTime,
            string id,
            global::LangSmith.RunsSearchCursorDirection direction)
        {
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsSearchCursor" /> class.
        /// </summary>
        public RunsSearchCursor()
        {
        }
    }
}