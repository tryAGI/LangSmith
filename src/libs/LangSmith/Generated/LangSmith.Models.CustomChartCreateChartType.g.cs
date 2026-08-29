
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomChartCreateChartType
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
    public static class CustomChartCreateChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartCreateChartType value)
        {
            return value switch
            {
                CustomChartCreateChartType.Bar => "bar",
                CustomChartCreateChartType.Kpi => "kpi",
                CustomChartCreateChartType.Line => "line",
                CustomChartCreateChartType.Pie => "pie",
                CustomChartCreateChartType.Table => "table",
                CustomChartCreateChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartCreateChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => CustomChartCreateChartType.Bar,
                "kpi" => CustomChartCreateChartType.Kpi,
                "line" => CustomChartCreateChartType.Line,
                "pie" => CustomChartCreateChartType.Pie,
                "table" => CustomChartCreateChartType.Table,
                "top-k" => CustomChartCreateChartType.TopK,
                _ => null,
            };
        }
    }
}