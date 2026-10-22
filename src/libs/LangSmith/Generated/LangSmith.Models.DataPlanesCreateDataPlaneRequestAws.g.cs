
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneRequestAws
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_tags")]
        public global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? AdditionalTags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byoiam")]
        public global::LangSmith.DataPlanesCreateDataPlaneBYOIAMSettings? Byoiam { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byovpc")]
        public global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? Byovpc { get; set; }

        /// <summary>
        /// Use a public EKS API endpoint restricted to LangSmith control-plane egress IPs instead of creating a managed PrivateLink endpoint service. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eks_api_privatelink_disabled")]
        public bool? EksApiPrivatelinkDisabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_load_balancer")]
        public bool? PublicLoadBalancer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// TraceStorage selects the run and trace store. Defaults to SMITHDB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DataPlanesDataPlaneTraceStorageJsonConverter))]
        public global::LangSmith.DataPlanesDataPlaneTraceStorage? TraceStorage { get; set; }

        /// <summary>
        /// VPCCIDR is used only when LangSmith creates the VPC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpc_cidr")]
        public string? VpcCidr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneRequestAws" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <param name="roleArn"></param>
        /// <param name="additionalTags"></param>
        /// <param name="byoiam"></param>
        /// <param name="byovpc"></param>
        /// <param name="eksApiPrivatelinkDisabled">
        /// Use a public EKS API endpoint restricted to LangSmith control-plane egress IPs instead of creating a managed PrivateLink endpoint service. Defaults to false.
        /// </param>
        /// <param name="publicLoadBalancer"></param>
        /// <param name="traceStorage">
        /// TraceStorage selects the run and trace store. Defaults to SMITHDB.
        /// </param>
        /// <param name="vpcCidr">
        /// VPCCIDR is used only when LangSmith creates the VPC.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneRequestAws(
            string name,
            string region,
            string roleArn,
            global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? additionalTags,
            global::LangSmith.DataPlanesCreateDataPlaneBYOIAMSettings? byoiam,
            global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? byovpc,
            bool? eksApiPrivatelinkDisabled,
            bool? publicLoadBalancer,
            global::LangSmith.DataPlanesDataPlaneTraceStorage? traceStorage,
            string? vpcCidr)
        {
            this.AdditionalTags = additionalTags;
            this.Byoiam = byoiam;
            this.Byovpc = byovpc;
            this.EksApiPrivatelinkDisabled = eksApiPrivatelinkDisabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PublicLoadBalancer = publicLoadBalancer;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.TraceStorage = traceStorage;
            this.VpcCidr = vpcCidr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneRequestAws" /> class.
        /// </summary>
        public DataPlanesCreateDataPlaneRequestAws()
        {
        }

    }
}