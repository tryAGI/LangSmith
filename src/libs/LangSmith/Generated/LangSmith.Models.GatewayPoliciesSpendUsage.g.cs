
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GatewayPoliciesSpendUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.IList<string>? Providers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// SpendUSD is the spend recorded in this window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_usd")]
        public double? SpendUsd { get; set; }

        /// <summary>
        /// Window is the spend limit period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        public string? Window { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesSpendUsage" /> class.
        /// </summary>
        /// <param name="providers"></param>
        /// <param name="scope"></param>
        /// <param name="spendUsd">
        /// SpendUSD is the spend recorded in this window.
        /// </param>
        /// <param name="window">
        /// Window is the spend limit period.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayPoliciesSpendUsage(
            global::System.Collections.Generic.IList<string>? providers,
            string? scope,
            double? spendUsd,
            string? window)
        {
            this.Providers = providers;
            this.Scope = scope;
            this.SpendUsd = spendUsd;
            this.Window = window;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPoliciesSpendUsage" /> class.
        /// </summary>
        public GatewayPoliciesSpendUsage()
        {
        }

    }
}