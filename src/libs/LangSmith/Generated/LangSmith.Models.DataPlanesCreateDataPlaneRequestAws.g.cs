
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneRequestAws
    {
        /// <summary>
        /// ExternalID is the value LangSmith presents as ExternalId when assuming role_arn. Must<br/>
        /// match the ExternalId condition in the customer role's trust policy. Required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// 
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
        /// <param name="externalId">
        /// ExternalID is the value LangSmith presents as ExternalId when assuming role_arn. Must<br/>
        /// match the ExternalId condition in the customer role's trust policy. Required.
        /// </param>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <param name="roleArn"></param>
        /// <param name="vpcCidr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneRequestAws(
            string? externalId,
            string? name,
            string? region,
            string? roleArn,
            string? vpcCidr)
        {
            this.ExternalId = externalId;
            this.Name = name;
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