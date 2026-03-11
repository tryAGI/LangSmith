
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Info about an org's automated startup-to-Plus plan transition.
    /// </summary>
    public sealed partial class PlusPlanTransitionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime TransitionDate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_tier_before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string PlanTierBefore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transitioned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Transitioned { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlusPlanTransitionInfo" /> class.
        /// </summary>
        /// <param name="transitionDate"></param>
        /// <param name="planTierBefore"></param>
        /// <param name="transitioned"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlusPlanTransitionInfo(
            global::System.DateTime transitionDate,
            string planTierBefore,
            bool transitioned)
        {
            this.TransitionDate = transitionDate;
            this.PlanTierBefore = planTierBefore ?? throw new global::System.ArgumentNullException(nameof(planTierBefore));
            this.Transitioned = transitioned;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlusPlanTransitionInfo" /> class.
        /// </summary>
        public PlusPlanTransitionInfo()
        {
        }
    }
}