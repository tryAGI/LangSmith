
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkExportDestinationUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::LangSmith.BulkExportDestinationS3Credentials? Credentials { get; set; }

        /// <summary>
        /// AWS IAM role ARN that LangSmith assumes instead of using static credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_arn")]
        public string? AwsRoleArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationUpdate" /> class.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="awsRoleArn">
        /// AWS IAM role ARN that LangSmith assumes instead of using static credentials.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportDestinationUpdate(
            global::LangSmith.BulkExportDestinationS3Credentials? credentials,
            string? awsRoleArn)
        {
            this.Credentials = credentials;
            this.AwsRoleArn = awsRoleArn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationUpdate" /> class.
        /// </summary>
        public BulkExportDestinationUpdate()
        {
        }

    }
}