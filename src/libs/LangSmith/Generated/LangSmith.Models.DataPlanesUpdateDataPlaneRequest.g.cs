
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesUpdateDataPlaneRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firewall")]
        public global::LangSmith.DataPlanesUpdateDataPlaneFirewallSettings? Firewall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fleet_oidc")]
        public global::LangSmith.DataPlanesUpdateDataPlaneFleetOIDCSettings? FleetOidc { get; set; }

        /// <summary>
        /// MaintenanceWindow is the two-hour weekly maintenance window in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintenance_window")]
        public string? MaintenanceWindow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesUpdateDataPlaneRequest" /> class.
        /// </summary>
        /// <param name="firewall"></param>
        /// <param name="fleetOidc"></param>
        /// <param name="maintenanceWindow">
        /// MaintenanceWindow is the two-hour weekly maintenance window in UTC.
        /// </param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesUpdateDataPlaneRequest(
            global::LangSmith.DataPlanesUpdateDataPlaneFirewallSettings? firewall,
            global::LangSmith.DataPlanesUpdateDataPlaneFleetOIDCSettings? fleetOidc,
            string? maintenanceWindow,
            global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings? ttl)
        {
            this.Firewall = firewall;
            this.FleetOidc = fleetOidc;
            this.MaintenanceWindow = maintenanceWindow;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesUpdateDataPlaneRequest" /> class.
        /// </summary>
        public DataPlanesUpdateDataPlaneRequest()
        {
        }

    }
}