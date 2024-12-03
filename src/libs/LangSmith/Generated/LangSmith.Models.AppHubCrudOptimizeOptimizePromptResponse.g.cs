
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response from optimizing a prompt.
    /// </summary>
    public sealed partial class AppHubCrudOptimizeOptimizePromptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppHubCrudOptimizeOptimizePromptResponse" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="error"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppHubCrudOptimizeOptimizePromptResponse(
            string prompt,
            string? error)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppHubCrudOptimizeOptimizePromptResponse" /> class.
        /// </summary>
        public AppHubCrudOptimizeOptimizePromptResponse()
        {
        }
    }
}