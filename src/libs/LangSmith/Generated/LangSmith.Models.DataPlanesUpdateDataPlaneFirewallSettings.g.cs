
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesUpdateDataPlaneFirewallSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_cidrs")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? AllowedCidrs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesUpdateDataPlaneFirewallSettings" /> class.
        /// </summary>
        /// <param name="allowedCidrs"></param>
        /// <param name="allowedDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesUpdateDataPlaneFirewallSettings(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? allowedCidrs,
            global::System.Collections.Generic.IList<string>? allowedDomains)
        {
            this.AllowedCidrs = allowedCidrs;
            this.AllowedDomains = allowedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesUpdateDataPlaneFirewallSettings" /> class.
        /// </summary>
        public DataPlanesUpdateDataPlaneFirewallSettings()
        {
        }

    }
}