
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardLayoutOutput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>1</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int Version { get; set; } = 1;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.DashboardLayoutBreakpointsOutput Breakpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutOutput" /> class.
        /// </summary>
        /// <param name="breakpoints"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardLayoutOutput(
            global::LangSmith.DashboardLayoutBreakpointsOutput breakpoints,
            int version = 1)
        {
            this.Version = version;
            this.Breakpoints = breakpoints ?? throw new global::System.ArgumentNullException(nameof(breakpoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardLayoutOutput" /> class.
        /// </summary>
        public DashboardLayoutOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DashboardLayoutOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DashboardLayoutOutput FromBreakpoints(global::LangSmith.DashboardLayoutBreakpointsOutput breakpoints)
        {
            return new DashboardLayoutOutput
            {
                Breakpoints = breakpoints,
            };
        }

    }
}