
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response for grouped comparison view of dataset examples.<br/>
    /// Returns dataset examples grouped by a run metadata value (e.g., model='gpt-4').<br/>
    /// Optional filters are applied to all runs before grouping.<br/>
    /// Shows:<br/>
    /// - Which examples were executed with each metadata value<br/>
    /// - Per-session aggregate statistics for runs on those examples<br/>
    /// - The actual example data with their associated runs<br/>
    /// Used for comparing how different sessions performed on the same set of examples.
    /// </summary>
    public sealed partial class GroupedExamplesWithRunsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleGroupWithSessions> Groups { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedExamplesWithRunsResponse" /> class.
        /// </summary>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupedExamplesWithRunsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.ExampleGroupWithSessions> groups)
        {
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedExamplesWithRunsResponse" /> class.
        /// </summary>
        public GroupedExamplesWithRunsResponse()
        {
        }
    }
}