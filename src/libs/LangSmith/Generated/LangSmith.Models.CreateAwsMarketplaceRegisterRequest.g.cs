
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAwsMarketplaceRegisterRequest
    {
        /// <summary>
        /// Registration token from AWS Marketplace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-amzn-marketplace-token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XAmznMarketplaceToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAwsMarketplaceRegisterRequest" /> class.
        /// </summary>
        /// <param name="xAmznMarketplaceToken">
        /// Registration token from AWS Marketplace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAwsMarketplaceRegisterRequest(
            string xAmznMarketplaceToken)
        {
            this.XAmznMarketplaceToken = xAmznMarketplaceToken ?? throw new global::System.ArgumentNullException(nameof(xAmznMarketplaceToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAwsMarketplaceRegisterRequest" /> class.
        /// </summary>
        public CreateAwsMarketplaceRegisterRequest()
        {
        }
    }
}