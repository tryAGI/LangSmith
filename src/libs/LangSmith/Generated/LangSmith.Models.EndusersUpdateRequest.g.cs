
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndusersUpdateRequest
    {
        /// <summary>
        /// Traits to merge into the stored traits. A key with a null value is removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Traits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndusersUpdateRequest" /> class.
        /// </summary>
        /// <param name="traits">
        /// Traits to merge into the stored traits. A key with a null value is removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndusersUpdateRequest(
            object traits)
        {
            this.Traits = traits ?? throw new global::System.ArgumentNullException(nameof(traits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndusersUpdateRequest" /> class.
        /// </summary>
        public EndusersUpdateRequest()
        {
        }

    }
}