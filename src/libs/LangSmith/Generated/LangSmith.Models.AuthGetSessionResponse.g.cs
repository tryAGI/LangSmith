
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthGetSessionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuthSessionStatusJsonConverter))]
        public global::LangSmith.AuthSessionStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthGetSessionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthGetSessionResponse(
            string? id,
            global::LangSmith.AuthSessionStatus? status)
        {
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthGetSessionResponse" /> class.
        /// </summary>
        public AuthGetSessionResponse()
        {
        }

    }
}