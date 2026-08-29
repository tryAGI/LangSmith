
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType
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
        Text,
        /// <summary>
        ///
        /// </summary>
        TopK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType value)
        {
            return value switch
            {
                ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Bar => "bar",
                ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Kpi => "kpi",
                ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Line => "line",
                ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Pie => "pie",
                ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Table => "table",
                ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Text => "text",
                ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Bar,
                "kpi" => ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Kpi,
                "line" => ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Line,
                "pie" => ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Pie,
                "table" => ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Table,
                "text" => ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Text,
                "top-k" => ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.TopK,
                _ => null,
            };
        }
    }
}