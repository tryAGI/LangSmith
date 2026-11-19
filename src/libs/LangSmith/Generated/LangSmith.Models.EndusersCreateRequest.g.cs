
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndusersCreateRequest
    {
        /// <summary>
        /// Traits to store, such as name and email. Defaults to an empty object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traits")]
        public object? Traits { get; set; }

        /// <summary>
        /// The user's ID, as sent in metadata.user_id on runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndusersCreateRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user's ID, as sent in metadata.user_id on runs.
        /// </param>
        /// <param name="traits">
        /// Traits to store, such as name and email. Defaults to an empty object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndusersCreateRequest(
            string userId,
            object? traits)
        {
            this.Traits = traits;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndusersCreateRequest" /> class.
        /// </summary>
        public EndusersCreateRequest()
        {
        }

    }
}