
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsanalyticsQueryUsersResponse
    {
        /// <summary>
        /// IsPartial is true when discovery reaches its work limit before filling the requested page.<br/>
        /// A full page can have is_partial=false and a non-null next_cursor.<br/>
        /// Always use next_cursor to determine whether to continue, including after an empty partial page.<br/>
        /// Available statistics for returned users cover the entire requested window.<br/>
        /// Missing statistics are indicated by each user's stats_status, not is_partial.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_partial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPartial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.RunsanalyticsProjectUser> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsQueryUsersResponse" /> class.
        /// </summary>
        /// <param name="isPartial">
        /// IsPartial is true when discovery reaches its work limit before filling the requested page.<br/>
        /// A full page can have is_partial=false and a non-null next_cursor.<br/>
        /// Always use next_cursor to determine whether to continue, including after an empty partial page.<br/>
        /// Available statistics for returned users cover the entire requested window.<br/>
        /// Missing statistics are indicated by each user's stats_status, not is_partial.
        /// </param>
        /// <param name="items"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsanalyticsQueryUsersResponse(
            bool isPartial,
            global::System.Collections.Generic.IList<global::LangSmith.RunsanalyticsProjectUser> items,
            string? nextCursor)
        {
            this.IsPartial = isPartial;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsQueryUsersResponse" /> class.
        /// </summary>
        public RunsanalyticsQueryUsersResponse()
        {
        }

    }
}