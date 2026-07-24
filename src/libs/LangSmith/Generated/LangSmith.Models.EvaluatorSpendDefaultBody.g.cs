
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request shape for PUT. Matchers, name, type, action, and priority<br/>
    /// are server-defined; only limit and window are caller-controlled.
    /// </summary>
    public sealed partial class EvaluatorSpendDefaultBody
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.EvaluatorSpendDefaultBodyWindowJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.EvaluatorSpendDefaultBodyWindow Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorSpendDefaultBody" /> class.
        /// </summary>
        /// <param name="limitUsd"></param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorSpendDefaultBody(
            double limitUsd,
            global::LangSmith.EvaluatorSpendDefaultBodyWindow window)
        {
            this.LimitUsd = limitUsd;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorSpendDefaultBody" /> class.
        /// </summary>
        public EvaluatorSpendDefaultBody()
        {
        }

    }
}