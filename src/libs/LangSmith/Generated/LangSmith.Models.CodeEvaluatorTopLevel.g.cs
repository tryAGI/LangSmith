
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeEvaluatorTopLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Default Value: python
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::LangSmith.CodeEvaluatorLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEvaluatorTopLevel" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="language">
        /// Default Value: python
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeEvaluatorTopLevel(
            string code,
            global::LangSmith.CodeEvaluatorLanguage? language)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEvaluatorTopLevel" /> class.
        /// </summary>
        public CodeEvaluatorTopLevel()
        {
        }
    }
}