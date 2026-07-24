
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for custom chart types.
    /// </summary>
    public enum CustomChartType
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
    public static class CustomChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartType value)
        {
            return value switch
            {
                CustomChartType.Bar => "bar",
                CustomChartType.Kpi => "kpi",
                CustomChartType.Line => "line",
                CustomChartType.Pie => "pie",
                CustomChartType.Table => "table",
                CustomChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => CustomChartType.Bar,
                "kpi" => CustomChartType.Kpi,
                "line" => CustomChartType.Line,
                "pie" => CustomChartType.Pie,
                "table" => CustomChartType.Table,
                "top-k" => CustomChartType.TopK,
                _ => null,
            };
        }
    }
}