
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType
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
    public static class UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType value)
        {
            return value switch
            {
                UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Bar => "bar",
                UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Kpi => "kpi",
                UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Line => "line",
                UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Pie => "pie",
                UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Table => "table",
                UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Text => "text",
                UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Bar,
                "kpi" => UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Kpi,
                "line" => UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Line,
                "pie" => UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Pie,
                "table" => UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Table,
                "text" => UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.Text,
                "top-k" => UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType.TopK,
                _ => null,
            };
        }
    }
}