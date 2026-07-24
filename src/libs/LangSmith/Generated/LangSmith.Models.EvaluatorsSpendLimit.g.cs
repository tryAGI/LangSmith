
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsSpendLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utilization_pct")]
        public double? UtilizationPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        public string? Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsSpendLimit" /> class.
        /// </summary>
        /// <param name="limitUsd"></param>
        /// <param name="utilizationPct"></param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsSpendLimit(
            double? limitUsd,
            double? utilizationPct,
            string? window)
        {
            this.LimitUsd = limitUsd;
            this.UtilizationPct = utilizationPct;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsSpendLimit" /> class.
        /// </summary>
        public EvaluatorsSpendLimit()
        {
        }

    }
}