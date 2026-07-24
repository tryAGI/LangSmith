
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataPlanesErrorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_permissions")]
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesMissingPermission>? MissingPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesErrorResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="error"></param>
        /// <param name="missingPermissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesErrorResponse(
            string? code,
            string? error,
            global::System.Collections.Generic.IList<global::LangSmith.DataPlanesMissingPermission>? missingPermissions)
        {
            this.Code = code;
            this.Error = error;
            this.MissingPermissions = missingPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesErrorResponse" /> class.
        /// </summary>
        public DataPlanesErrorResponse()
        {
        }

    }
}