
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Stripe customer billing information.
    /// </summary>
    public sealed partial class StripeBusinessBillingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Stripe customer address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public global::LangSmith.StripeCustomerAddress? Address { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessBillingInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address">
        /// Stripe customer address.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StripeBusinessBillingInfo(
            string name,
            global::LangSmith.StripeCustomerAddress? address)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Address = address;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessBillingInfo" /> class.
        /// </summary>
        public StripeBusinessBillingInfo()
        {
        }
    }
}