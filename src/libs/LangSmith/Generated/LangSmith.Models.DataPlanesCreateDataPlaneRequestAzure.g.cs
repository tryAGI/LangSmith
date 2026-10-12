
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneRequestAzure
    {
        /// <summary>
        /// EntraTenantID is the Microsoft Entra tenant of the resource group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_entra_tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AzureEntraTenantId { get; set; }

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
        /// ResourceGroupID is /subscriptions/&lt;subscription ID&gt;/resourceGroups/&lt;name&gt;:<br/>
        /// the group that the LangSmith BYOC Terraform module created for this data<br/>
        /// plane. It must contain only the data plane Key Vault. LangSmith deletes the<br/>
        /// group when the data plane is deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceGroupId { get; set; }

        /// <summary>
        /// VPCCIDR is the VNet that LangSmith creates.
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
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneRequestAzure" /> class.
        /// </summary>
        /// <param name="azureEntraTenantId">
        /// EntraTenantID is the Microsoft Entra tenant of the resource group.
        /// </param>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <param name="resourceGroupId">
        /// ResourceGroupID is /subscriptions/&lt;subscription ID&gt;/resourceGroups/&lt;name&gt;:<br/>
        /// the group that the LangSmith BYOC Terraform module created for this data<br/>
        /// plane. It must contain only the data plane Key Vault. LangSmith deletes the<br/>
        /// group when the data plane is deleted.
        /// </param>
        /// <param name="vpcCidr">
        /// VPCCIDR is the VNet that LangSmith creates.
        /// </param>
        /// <param name="publicLoadBalancer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneRequestAzure(
            string azureEntraTenantId,
            string name,
            string region,
            string resourceGroupId,
            string vpcCidr,
            bool? publicLoadBalancer)
        {
            this.AzureEntraTenantId = azureEntraTenantId ?? throw new global::System.ArgumentNullException(nameof(azureEntraTenantId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PublicLoadBalancer = publicLoadBalancer;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ResourceGroupId = resourceGroupId ?? throw new global::System.ArgumentNullException(nameof(resourceGroupId));
            this.VpcCidr = vpcCidr ?? throw new global::System.ArgumentNullException(nameof(vpcCidr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneRequestAzure" /> class.
        /// </summary>
        public DataPlanesCreateDataPlaneRequestAzure()
        {
        }

    }
}