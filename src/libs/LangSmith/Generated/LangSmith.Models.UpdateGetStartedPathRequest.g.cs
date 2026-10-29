
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateGetStartedPathRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.GetStartedPathJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.GetStartedPath Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGetStartedPathRequest" /> class.
        /// </summary>
        /// <param name="path"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGetStartedPathRequest(
            global::LangSmith.GetStartedPath path)
        {
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGetStartedPathRequest" /> class.
        /// </summary>
        public UpdateGetStartedPathRequest()
        {
        }

    }
}