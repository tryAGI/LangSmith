
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF product object.
    /// </summary>
    public sealed partial class OCSFProduct
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string VendorName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFProduct" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="vendorName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFProduct(
            string name,
            string vendorName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VendorName = vendorName ?? throw new global::System.ArgumentNullException(nameof(vendorName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFProduct" /> class.
        /// </summary>
        public OCSFProduct()
        {
        }
    }
}