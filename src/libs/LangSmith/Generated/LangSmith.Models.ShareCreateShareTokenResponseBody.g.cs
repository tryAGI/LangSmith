
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShareCreateShareTokenResponseBody
    {
        /// <summary>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        public global::System.Guid? ShareToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCreateShareTokenResponseBody" /> class.
        /// </summary>
        /// <param name="shareToken">
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareCreateShareTokenResponseBody(
            global::System.Guid? shareToken)
        {
            this.ShareToken = shareToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCreateShareTokenResponseBody" /> class.
        /// </summary>
        public ShareCreateShareTokenResponseBody()
        {
        }

    }
}