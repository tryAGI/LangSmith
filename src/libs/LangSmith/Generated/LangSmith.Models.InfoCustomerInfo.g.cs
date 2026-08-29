
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfoCustomerInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_name")]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoCustomerInfo" /> class.
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="customerName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoCustomerInfo(
            string? customerId,
            string? customerName)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoCustomerInfo" /> class.
        /// </summary>
        public InfoCustomerInfo()
        {
        }

    }
}