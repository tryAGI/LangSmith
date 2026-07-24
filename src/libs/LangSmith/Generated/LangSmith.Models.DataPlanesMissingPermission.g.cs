
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataPlanesMissingPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        public string? Decision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_arn")]
        public string? ResourceArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesMissingPermission" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="decision"></param>
        /// <param name="resourceArn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesMissingPermission(
            string? action,
            string? decision,
            string? resourceArn)
        {
            this.Action = action;
            this.Decision = decision;
            this.ResourceArn = resourceArn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesMissingPermission" /> class.
        /// </summary>
        public DataPlanesMissingPermission()
        {
        }

    }
}