
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ThreadsSandboxActivationProblem
    {
        /// <summary>
        /// Example: sandbox_not_ready
        /// </summary>
        /// <example>sandbox_not_ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Example: The thread does not have a sandbox slug to activate.
        /// </summary>
        /// <example>The thread does not have a sandbox slug to activate.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Example: 409
        /// </summary>
        /// <example>409</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Status { get; set; }

        /// <summary>
        /// Example: Conflict
        /// </summary>
        /// <example>Conflict</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Example: about:blank
        /// </summary>
        /// <example>about:blank</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsSandboxActivationProblem" /> class.
        /// </summary>
        /// <param name="code">
        /// Example: sandbox_not_ready
        /// </param>
        /// <param name="detail">
        /// Example: The thread does not have a sandbox slug to activate.
        /// </param>
        /// <param name="status">
        /// Example: 409
        /// </param>
        /// <param name="title">
        /// Example: Conflict
        /// </param>
        /// <param name="type">
        /// Example: about:blank
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsSandboxActivationProblem(
            string code,
            string detail,
            int status,
            string title,
            string type)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Status = status;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsSandboxActivationProblem" /> class.
        /// </summary>
        public ThreadsSandboxActivationProblem()
        {
        }

    }
}