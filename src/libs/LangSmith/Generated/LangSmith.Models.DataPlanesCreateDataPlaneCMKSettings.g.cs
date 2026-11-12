
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneCMKSettings
    {
        /// <summary>
        /// KMS key ARN that encrypts S3, EBS, EKS secrets, RDS, and ElastiCache. Must be in the data plane region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_arn")]
        public string? KeyArn { get; set; }

        /// <summary>
        /// KMS key ARNs keyed by service: s3, ebs, eks, rds, or elasticache. Each overrides key_arn for its service. Without key_arn, services not listed keep AWS-managed encryption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_key_arns")]
        public global::System.Collections.Generic.Dictionary<string, string>? ServiceKeyArns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneCMKSettings" /> class.
        /// </summary>
        /// <param name="keyArn">
        /// KMS key ARN that encrypts S3, EBS, EKS secrets, RDS, and ElastiCache. Must be in the data plane region.
        /// </param>
        /// <param name="serviceKeyArns">
        /// KMS key ARNs keyed by service: s3, ebs, eks, rds, or elasticache. Each overrides key_arn for its service. Without key_arn, services not listed keep AWS-managed encryption.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneCMKSettings(
            string? keyArn,
            global::System.Collections.Generic.Dictionary<string, string>? serviceKeyArns)
        {
            this.KeyArn = keyArn;
            this.ServiceKeyArns = serviceKeyArns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneCMKSettings" /> class.
        /// </summary>
        public DataPlanesCreateDataPlaneCMKSettings()
        {
        }

    }
}