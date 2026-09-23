
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
        /// Use customer-managed IAM roles created by the LangSmith BYOIAM Terraform module.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byoiam_enabled")]
        public bool? ByoiamEnabled { get; set; }

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
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_load_balancer")]
        public bool? PublicLoadBalancer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

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
        /// <param name="additionalTags"></param>
        /// <param name="byoiamEnabled">
        /// Use customer-managed IAM roles created by the LangSmith BYOIAM Terraform module.
        /// </param>
        /// <param name="byovpc"></param>
        /// <param name="eksApiPrivatelinkDisabled">
        /// Use a public EKS API endpoint restricted to LangSmith control-plane egress IPs instead of creating a managed PrivateLink endpoint service. Defaults to false.
        /// </param>
        /// <param name="name"></param>
        /// <param name="publicLoadBalancer"></param>
        /// <param name="region"></param>
        /// <param name="roleArn"></param>
        /// <param name="vpcCidr">
        /// VPCCIDR is used only when LangSmith creates the VPC.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneRequestAws(
            global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? additionalTags,
            bool? byoiamEnabled,
            global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? byovpc,
            bool? eksApiPrivatelinkDisabled,
            string? name,
            bool? publicLoadBalancer,
            string? region,
            string? roleArn,
            string? vpcCidr)
        {
            this.AdditionalTags = additionalTags;
            this.ByoiamEnabled = byoiamEnabled;
            this.Byovpc = byovpc;
            this.EksApiPrivatelinkDisabled = eksApiPrivatelinkDisabled;
            this.Name = name;
            this.PublicLoadBalancer = publicLoadBalancer;
            this.Region = region;
            this.RoleArn = roleArn;
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