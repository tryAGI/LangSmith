
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeBusinessInfoInput
    {
        /// <summary>
        /// Stripe customer billing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_info")]
        public global::LangSmith.StripeBusinessBillingInfo? CompanyInfo { get; set; }

        /// <summary>
        /// Stripe tax ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_id")]
        public global::LangSmith.StripeTaxId? TaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_email")]
        public string? InvoiceEmail { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_business")]
        public bool? IsBusiness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessInfoInput" /> class.
        /// </summary>
        /// <param name="companyInfo">
        /// Stripe customer billing information.
        /// </param>
        /// <param name="taxId">
        /// Stripe tax ID.
        /// </param>
        /// <param name="invoiceEmail"></param>
        /// <param name="isBusiness">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeBusinessInfoInput(
            global::LangSmith.StripeBusinessBillingInfo? companyInfo,
            global::LangSmith.StripeTaxId? taxId,
            string? invoiceEmail,
            bool? isBusiness)
        {
            this.CompanyInfo = companyInfo;
            this.TaxId = taxId;
            this.InvoiceEmail = invoiceEmail;
            this.IsBusiness = isBusiness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessInfoInput" /> class.
        /// </summary>
        public StripeBusinessInfoInput()
        {
        }
    }
}