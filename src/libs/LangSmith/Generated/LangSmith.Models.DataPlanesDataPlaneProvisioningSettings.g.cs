
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesDataPlaneProvisioningSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? AdditionalTags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byovpc")]
        public global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? Byovpc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DataPlanesDataPlaneCloudJsonConverter))]
        public global::LangSmith.DataPlanesDataPlaneCloud? Cloud { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byoiam_enabled")]
        public bool? IsByoiamEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_eks_api_privatelink_disabled")]
        public bool? IsEksApiPrivatelinkDisabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public_load_balancer")]
        public bool? IsPublicLoadBalancer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// VPCCIDR is the effective VPC CIDR, including for customer-managed VPCs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpc_cidr")]
        public string? VpcCidr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneProvisioningSettings" /> class.
        /// </summary>
        /// <param name="additionalTags"></param>
        /// <param name="byovpc"></param>
        /// <param name="cloud"></param>
        /// <param name="isByoiamEnabled"></param>
        /// <param name="isEksApiPrivatelinkDisabled"></param>
        /// <param name="isPublicLoadBalancer"></param>
        /// <param name="roleArn"></param>
        /// <param name="vpcCidr">
        /// VPCCIDR is the effective VPC CIDR, including for customer-managed VPCs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneProvisioningSettings(
            global::System.Collections.Generic.Dictionary<string, string>? additionalTags,
            global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? byovpc,
            global::LangSmith.DataPlanesDataPlaneCloud? cloud,
            bool? isByoiamEnabled,
            bool? isEksApiPrivatelinkDisabled,
            bool? isPublicLoadBalancer,
            string? roleArn,
            string? vpcCidr)
        {
            this.AdditionalTags = additionalTags;
            this.Byovpc = byovpc;
            this.Cloud = cloud;
            this.IsByoiamEnabled = isByoiamEnabled;
            this.IsEksApiPrivatelinkDisabled = isEksApiPrivatelinkDisabled;
            this.IsPublicLoadBalancer = isPublicLoadBalancer;
            this.RoleArn = roleArn;
            this.VpcCidr = vpcCidr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneProvisioningSettings" /> class.
        /// </summary>
        public DataPlanesDataPlaneProvisioningSettings()
        {
        }

    }
}