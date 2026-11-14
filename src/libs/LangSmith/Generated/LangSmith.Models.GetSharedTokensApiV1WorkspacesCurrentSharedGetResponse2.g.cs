
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2
    {
        /// <summary>
        /// One message per invalid parameter, prefixed with its location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2" /> class.
        /// </summary>
        /// <param name="errors">
        /// One message per invalid parameter, prefixed with its location.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2(
            global::System.Collections.Generic.IList<string> errors)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2" /> class.
        /// </summary>
        public GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2()
        {
        }

    }
}