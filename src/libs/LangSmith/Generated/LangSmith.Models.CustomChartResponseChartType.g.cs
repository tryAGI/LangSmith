
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomChartResponseChartType
    {
        /// <summary>
        ///
        /// </summary>
        Bar,
        /// <summary>
        ///
        /// </summary>
        Kpi,
        /// <summary>
        ///
        /// </summary>
        Line,
        /// <summary>
        ///
        /// </summary>
        Pie,
        /// <summary>
        ///
        /// </summary>
        Table,
        /// <summary>
        ///
        /// </summary>
        TopK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomChartResponseChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartResponseChartType value)
        {
            return value switch
            {
                CustomChartResponseChartType.Bar => "bar",
                CustomChartResponseChartType.Kpi => "kpi",
                CustomChartResponseChartType.Line => "line",
                CustomChartResponseChartType.Pie => "pie",
                CustomChartResponseChartType.Table => "table",
                CustomChartResponseChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartResponseChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => CustomChartResponseChartType.Bar,
                "kpi" => CustomChartResponseChartType.Kpi,
                "line" => CustomChartResponseChartType.Line,
                "pie" => CustomChartResponseChartType.Pie,
                "table" => CustomChartResponseChartType.Table,
                "top-k" => CustomChartResponseChartType.TopK,
                _ => null,
            };
        }
    }
}