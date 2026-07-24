
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorSpendDefaultResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LimitUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorSpendDefaultResponse" /> class.
        /// </summary>
        /// <param name="limitUsd"></param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorSpendDefaultResponse(
            double limitUsd,
            string window)
        {
            this.LimitUsd = limitUsd;
            this.Window = window ?? throw new global::System.ArgumentNullException(nameof(window));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorSpendDefaultResponse" /> class.
        /// </summary>
        public EvaluatorSpendDefaultResponse()
        {
        }

    }
}