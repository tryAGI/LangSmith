
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SingleCustomChartResponseSerializedChartType
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
    public static class SingleCustomChartResponseSerializedChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SingleCustomChartResponseSerializedChartType value)
        {
            return value switch
            {
                SingleCustomChartResponseSerializedChartType.Bar => "bar",
                SingleCustomChartResponseSerializedChartType.Kpi => "kpi",
                SingleCustomChartResponseSerializedChartType.Line => "line",
                SingleCustomChartResponseSerializedChartType.Pie => "pie",
                SingleCustomChartResponseSerializedChartType.Table => "table",
                SingleCustomChartResponseSerializedChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SingleCustomChartResponseSerializedChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => SingleCustomChartResponseSerializedChartType.Bar,
                "kpi" => SingleCustomChartResponseSerializedChartType.Kpi,
                "line" => SingleCustomChartResponseSerializedChartType.Line,
                "pie" => SingleCustomChartResponseSerializedChartType.Pie,
                "table" => SingleCustomChartResponseSerializedChartType.Table,
                "top-k" => SingleCustomChartResponseSerializedChartType.TopK,
                _ => null,
            };
        }
    }
}