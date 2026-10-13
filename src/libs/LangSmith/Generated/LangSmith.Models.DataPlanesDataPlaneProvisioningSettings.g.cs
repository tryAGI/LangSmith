
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
        /// EntraTenantID is the Microsoft Entra tenant of the resource group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_tenant_id")]
        public string? AzureEntraTenantId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_group_id")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// TraceStorage is the run and trace store. It is SMITHDB when SmithDB is<br/>
        /// enabled and serves queries, and CLICKHOUSE otherwise, including for data<br/>
        /// planes created before this setting existed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DataPlanesDataPlaneTraceStorageJsonConverter))]
        public global::LangSmith.DataPlanesDataPlaneTraceStorage? TraceStorage { get; set; }

        /// <summary>
        /// VPCCIDR is the effective AWS VPC or Azure VNet CIDR, including for customer-managed VPCs.
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
        /// <param name="azureEntraTenantId">
        /// EntraTenantID is the Microsoft Entra tenant of the resource group.
        /// </param>
        /// <param name="byovpc"></param>
        /// <param name="cloud"></param>
        /// <param name="isByoiamEnabled"></param>
        /// <param name="isEksApiPrivatelinkDisabled"></param>
        /// <param name="isPublicLoadBalancer"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="roleArn"></param>
        /// <param name="traceStorage">
        /// TraceStorage is the run and trace store. It is SMITHDB when SmithDB is<br/>
        /// enabled and serves queries, and CLICKHOUSE otherwise, including for data<br/>
        /// planes created before this setting existed.
        /// </param>
        /// <param name="vpcCidr">
        /// VPCCIDR is the effective AWS VPC or Azure VNet CIDR, including for customer-managed VPCs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneProvisioningSettings(
            global::System.Collections.Generic.Dictionary<string, string>? additionalTags,
            string? azureEntraTenantId,
            global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? byovpc,
            global::LangSmith.DataPlanesDataPlaneCloud? cloud,
            bool? isByoiamEnabled,
            bool? isEksApiPrivatelinkDisabled,
            bool? isPublicLoadBalancer,
            string? resourceGroupId,
            string? roleArn,
            global::LangSmith.DataPlanesDataPlaneTraceStorage? traceStorage,
            string? vpcCidr)
        {
            this.AdditionalTags = additionalTags;
            this.AzureEntraTenantId = azureEntraTenantId;
            this.Byovpc = byovpc;
            this.Cloud = cloud;
            this.IsByoiamEnabled = isByoiamEnabled;
            this.IsEksApiPrivatelinkDisabled = isEksApiPrivatelinkDisabled;
            this.IsPublicLoadBalancer = isPublicLoadBalancer;
            this.ResourceGroupId = resourceGroupId;
            this.RoleArn = roleArn;
            this.TraceStorage = traceStorage;
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