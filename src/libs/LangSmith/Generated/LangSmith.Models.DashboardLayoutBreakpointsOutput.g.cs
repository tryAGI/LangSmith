
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardLayoutBreakpointsOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.DashboardBreakpointLayoutOutput Sm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.DashboardBreakpointLayoutOutput Md { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutBreakpointsOutput" /> class.
        /// </summary>
        /// <param name="sm"></param>
        /// <param name="md"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardLayoutBreakpointsOutput(
            global::LangSmith.DashboardBreakpointLayoutOutput sm,
            global::LangSmith.DashboardBreakpointLayoutOutput md)
        {
            this.Sm = sm ?? throw new global::System.ArgumentNullException(nameof(sm));
            this.Md = md ?? throw new global::System.ArgumentNullException(nameof(md));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutBreakpointsOutput" /> class.
        /// </summary>
        public DashboardLayoutBreakpointsOutput()
        {
        }

    }
}