
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesValidationErrorDetail
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        public global::System.Collections.Generic.IList<string>? Loc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesValidationErrorDetail" /> class.
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="msg"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesValidationErrorDetail(
            global::System.Collections.Generic.IList<string>? loc,
            string? msg,
            string? type)
        {
            this.Loc = loc;
            this.Msg = msg;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesValidationErrorDetail" /> class.
        /// </summary>
        public SandboxesValidationErrorDetail()
        {
        }

    }
}