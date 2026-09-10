
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneRequestAws
    {
        /// <summary>
        /// The ID of the customer-managed VPC to deploy into when deploying in BYOVPC mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byovpc_id")]
        public string? ByovpcId { get; set; }

        /// <summary>
        /// The subnet IDs of the private app subnets to deploy into when deploying in BYOVPC mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byovpc_private_app_subnet_ids")]
        public global::System.Collections.Generic.IList<string>? ByovpcPrivateAppSubnetIds { get; set; }

        /// <summary>
        /// The subnet IDs of the private database subnets to deploy into when deploying in BYOVPC mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byovpc_private_db_subnet_ids")]
        public global::System.Collections.Generic.IList<string>? ByovpcPrivateDbSubnetIds { get; set; }

        /// <summary>
        /// The subnet IDs of the optional public subnets to deploy into when deploying in BYOVPC mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byovpc_public_subnet_ids")]
        public global::System.Collections.Generic.IList<string>? ByovpcPublicSubnetIds { get; set; }

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
        /// <param name="byovpcId">
        /// The ID of the customer-managed VPC to deploy into when deploying in BYOVPC mode.
        /// </param>
        /// <param name="byovpcPrivateAppSubnetIds">
        /// The subnet IDs of the private app subnets to deploy into when deploying in BYOVPC mode.
        /// </param>
        /// <param name="byovpcPrivateDbSubnetIds">
        /// The subnet IDs of the private database subnets to deploy into when deploying in BYOVPC mode.
        /// </param>
        /// <param name="byovpcPublicSubnetIds">
        /// The subnet IDs of the optional public subnets to deploy into when deploying in BYOVPC mode.
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
            string? byovpcId,
            global::System.Collections.Generic.IList<string>? byovpcPrivateAppSubnetIds,
            global::System.Collections.Generic.IList<string>? byovpcPrivateDbSubnetIds,
            global::System.Collections.Generic.IList<string>? byovpcPublicSubnetIds,
            string? name,
            bool? publicLoadBalancer,
            string? region,
            string? roleArn,
            string? vpcCidr)
        {
            this.ByovpcId = byovpcId;
            this.ByovpcPrivateAppSubnetIds = byovpcPrivateAppSubnetIds;
            this.ByovpcPrivateDbSubnetIds = byovpcPrivateDbSubnetIds;
            this.ByovpcPublicSubnetIds = byovpcPublicSubnetIds;
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