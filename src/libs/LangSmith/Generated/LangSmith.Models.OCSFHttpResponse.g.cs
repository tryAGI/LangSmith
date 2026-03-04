
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF HTTP response object.
    /// </summary>
    public sealed partial class OCSFHttpResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFHttpResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFHttpResponse(
            int? code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFHttpResponse" /> class.
        /// </summary>
        public OCSFHttpResponse()
        {
        }
    }
}