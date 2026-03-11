
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyExecuteApiV1AceExecutePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<object> Args { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExecuteApiV1AceExecutePost" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="code"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyExecuteApiV1AceExecutePost(
            global::System.Collections.Generic.IList<object> args,
            string code,
            string language)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExecuteApiV1AceExecutePost" /> class.
        /// </summary>
        public BodyExecuteApiV1AceExecutePost()
        {
        }
    }
}