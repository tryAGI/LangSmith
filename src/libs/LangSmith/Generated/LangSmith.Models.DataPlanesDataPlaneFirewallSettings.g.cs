
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesDataPlaneFirewallSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_http")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowHttp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_cidrs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>> AllowedCidrs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneFirewallSettings" /> class.
        /// </summary>
        /// <param name="allowHttp"></param>
        /// <param name="allowedCidrs"></param>
        /// <param name="allowedDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneFirewallSettings(
            bool allowHttp,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>> allowedCidrs,
            global::System.Collections.Generic.IList<string> allowedDomains)
        {
            this.AllowHttp = allowHttp;
            this.AllowedCidrs = allowedCidrs ?? throw new global::System.ArgumentNullException(nameof(allowedCidrs));
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneFirewallSettings" /> class.
        /// </summary>
        public DataPlanesDataPlaneFirewallSettings()
        {
        }

    }
}