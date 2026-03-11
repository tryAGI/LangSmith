
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Customer info.
    /// </summary>
    public sealed partial class CustomerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInfo" /> class.
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="customerName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerInfo(
            string customerId,
            string customerName)
        {
            this.CustomerId = customerId ?? throw new global::System.ArgumentNullException(nameof(customerId));
            this.CustomerName = customerName ?? throw new global::System.ArgumentNullException(nameof(customerName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInfo" /> class.
        /// </summary>
        public CustomerInfo()
        {
        }
    }
}