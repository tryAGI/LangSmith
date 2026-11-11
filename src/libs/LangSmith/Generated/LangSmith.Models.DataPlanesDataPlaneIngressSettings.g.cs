
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesDataPlaneIngressSettings
    {
        /// <summary>
        /// IPv4 CIDR blocks allowed to reach the data plane load balancer on port 443. Empty allows all sources. A private load balancer also always allows the data plane VPC CIDR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_source_cidrs")]
        public global::System.Collections.Generic.IList<string>? AllowedSourceCidrs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneIngressSettings" /> class.
        /// </summary>
        /// <param name="allowedSourceCidrs">
        /// IPv4 CIDR blocks allowed to reach the data plane load balancer on port 443. Empty allows all sources. A private load balancer also always allows the data plane VPC CIDR.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneIngressSettings(
            global::System.Collections.Generic.IList<string>? allowedSourceCidrs)
        {
            this.AllowedSourceCidrs = allowedSourceCidrs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneIngressSettings" /> class.
        /// </summary>
        public DataPlanesDataPlaneIngressSettings()
        {
        }

    }
}