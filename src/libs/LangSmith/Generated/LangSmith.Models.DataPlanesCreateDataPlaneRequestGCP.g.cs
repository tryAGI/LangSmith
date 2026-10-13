
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneRequestGCP
    {
        /// <summary>
        /// Use customer-managed service accounts created by the LangSmith GCP BYOC Terraform module with byo_iam = true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byoiam_enabled")]
        public bool? ByoiamEnabled { get; set; }

        /// <summary>
        /// ProjectID is the customer project that hosts the data plane.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcp_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GcpProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ProvisionerServiceAccount is the customer service account that the<br/>
        /// control plane impersonates to create the data plane resources. It must be<br/>
        /// in the project, and its description must be the organization's external ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioner_service_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProvisionerServiceAccount { get; set; }

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
        /// Deploy LangSmith sandboxes in the data plane. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxes_enabled")]
        public bool? SandboxesEnabled { get; set; }

        /// <summary>
        /// VPCCIDR is the VPC network that LangSmith creates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpc_cidr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VpcCidr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneRequestGCP" /> class.
        /// </summary>
        /// <param name="gcpProjectId">
        /// ProjectID is the customer project that hosts the data plane.
        /// </param>
        /// <param name="name"></param>
        /// <param name="provisionerServiceAccount">
        /// ProvisionerServiceAccount is the customer service account that the<br/>
        /// control plane impersonates to create the data plane resources. It must be<br/>
        /// in the project, and its description must be the organization's external ID.
        /// </param>
        /// <param name="region"></param>
        /// <param name="vpcCidr">
        /// VPCCIDR is the VPC network that LangSmith creates.
        /// </param>
        /// <param name="byoiamEnabled">
        /// Use customer-managed service accounts created by the LangSmith GCP BYOC Terraform module with byo_iam = true.
        /// </param>
        /// <param name="publicLoadBalancer"></param>
        /// <param name="sandboxesEnabled">
        /// Deploy LangSmith sandboxes in the data plane. Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneRequestGCP(
            string gcpProjectId,
            string name,
            string provisionerServiceAccount,
            string region,
            string vpcCidr,
            bool? byoiamEnabled,
            bool? publicLoadBalancer,
            bool? sandboxesEnabled)
        {
            this.ByoiamEnabled = byoiamEnabled;
            this.GcpProjectId = gcpProjectId ?? throw new global::System.ArgumentNullException(nameof(gcpProjectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProvisionerServiceAccount = provisionerServiceAccount ?? throw new global::System.ArgumentNullException(nameof(provisionerServiceAccount));
            this.PublicLoadBalancer = publicLoadBalancer;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.SandboxesEnabled = sandboxesEnabled;
            this.VpcCidr = vpcCidr ?? throw new global::System.ArgumentNullException(nameof(vpcCidr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneRequestGCP" /> class.
        /// </summary>
        public DataPlanesCreateDataPlaneRequestGCP()
        {
        }

    }
}