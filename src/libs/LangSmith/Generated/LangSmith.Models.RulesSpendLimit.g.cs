
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RulesSpendLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LimitUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RulesSpendLimitWindowJsonConverter))]
        public global::LangSmith.RulesSpendLimitWindow Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesSpendLimit" /> class.
        /// </summary>
        /// <param name="limitUsd"></param>
        /// <param name="window"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesSpendLimit(
            string limitUsd,
            global::LangSmith.RulesSpendLimitWindow window)
        {
            this.LimitUsd = limitUsd ?? throw new global::System.ArgumentNullException(nameof(limitUsd));
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesSpendLimit" /> class.
        /// </summary>
        public RulesSpendLimit()
        {
        }

    }
}