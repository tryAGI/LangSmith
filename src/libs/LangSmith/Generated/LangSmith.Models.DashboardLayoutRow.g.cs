
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardLayoutRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height_units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HeightUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutRow" /> class.
        /// </summary>
        /// <param name="heightUnits"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardLayoutRow(
            int heightUnits,
            global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutItem> items)
        {
            this.HeightUnits = heightUnits;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutRow" /> class.
        /// </summary>
        public DashboardLayoutRow()
        {
        }

    }
}