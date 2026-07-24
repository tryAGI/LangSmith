
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardLayoutItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ChartId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width_units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WidthUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutItem" /> class.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="widthUnits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardLayoutItem(
            global::System.Guid chartId,
            int widthUnits)
        {
            this.ChartId = chartId;
            this.WidthUnits = widthUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutItem" /> class.
        /// </summary>
        public DashboardLayoutItem()
        {
        }

    }
}