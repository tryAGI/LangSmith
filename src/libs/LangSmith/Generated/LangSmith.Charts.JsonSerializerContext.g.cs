
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>), TypeInfoPropertyName = "CustomChartMetricPercentile_3c8b9621ba7cc835")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_76d2f2f51478e166")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_9b2281ccf99763ac")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>?), TypeInfoPropertyName = "CustomChartMetricPercentile_ff9d133b07e10395")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_290a0cb75190567c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_17e37acb6be9a65c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Missing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, string>), TypeInfoPropertyName = "AnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreateChartType), TypeInfoPropertyName = "CustomChartCreateChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreatePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackCountMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackCountMetricParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricPercentile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricPercentileParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricScalar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricScalarParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFilterByDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFilterByTracingProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartGroupByComplex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartGroupByPlain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetric), TypeInfoPropertyName = "CustomChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricField), TypeInfoPropertyName = "CustomChartMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricPercentile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricPercentileParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricRatioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricScalar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricRatioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartResponseChartType), TypeInfoPropertyName = "CustomChartResponseChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HostProjectChartMetric), TypeInfoPropertyName = "HostProjectChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>), TypeInfoPropertyName = "AnyOfCustomChartGroupByPlainCustomChartGroupByComplex2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>), TypeInfoPropertyName = "AnyOfCustomChartFilterByTracingProjectCustomChartFilterByDatasetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartType), TypeInfoPropertyName = "CustomChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfStringMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfInt32Missing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfCustomChartTypeMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfIListCustomChartSeriesUpdateMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfGuidMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfCustomChartSeriesFiltersMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, double?, object, object>), TypeInfoPropertyName = "AnyOfInt32DoubleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TimedeltaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ChartsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChartsItem), TypeInfoPropertyName = "ChartsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseSerialized))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionChartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType), TypeInfoPropertyName = "CustomChartsSectionChartDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartSubSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.DashboardLayoutInput, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfDashboardLayoutInputMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionsCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomTextBlockCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomTextBlockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardBreakpointLayoutInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardBreakpointLayoutOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutBreakpointsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutBreakpointsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupByAttribute), TypeInfoPropertyName = "RunStatsGroupByAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute), TypeInfoPropertyName = "RunStatsGroupBySeriesResponseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy), TypeInfoPropertyName = "RunStatsGroupBySeriesResponseSetBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType), TypeInfoPropertyName = "SingleCustomChartResponseSerializedChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponseSerialized>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequest), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponse), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse), TypeInfoPropertyName = "ReadSingleChartApiV1ChartsChartIdPostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType), TypeInfoPropertyName = "ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse), TypeInfoPropertyName = "UpdateChartApiV1ChartsChartIdPatchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType), TypeInfoPropertyName = "UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, string>?), TypeInfoPropertyName = "NullableAnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreateChartType?), TypeInfoPropertyName = "NullableCustomChartCreateChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetric?), TypeInfoPropertyName = "NullableCustomChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricField?), TypeInfoPropertyName = "NullableCustomChartMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartResponseChartType?), TypeInfoPropertyName = "NullableCustomChartResponseChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HostProjectChartMetric?), TypeInfoPropertyName = "NullableHostProjectChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>?), TypeInfoPropertyName = "NullableAnyOfCustomChartGroupByPlainCustomChartGroupByComplex2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>?), TypeInfoPropertyName = "NullableAnyOfCustomChartFilterByTracingProjectCustomChartFilterByDatasetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartType?), TypeInfoPropertyName = "NullableCustomChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfStringMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfInt32Missing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfCustomChartTypeMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfIListCustomChartSeriesUpdateMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfGuidMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfCustomChartSeriesFiltersMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, double?, object, object>?), TypeInfoPropertyName = "NullableAnyOfInt32DoubleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChartsItem?), TypeInfoPropertyName = "NullableChartsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType?), TypeInfoPropertyName = "NullableCustomChartsSectionChartDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.DashboardLayoutInput, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfDashboardLayoutInputMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupByAttribute?), TypeInfoPropertyName = "NullableRunStatsGroupByAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute?), TypeInfoPropertyName = "NullableRunStatsGroupBySeriesResponseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy?), TypeInfoPropertyName = "NullableRunStatsGroupBySeriesResponseSetBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType?), TypeInfoPropertyName = "NullableSingleCustomChartResponseSerializedChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequest?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponse?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse?), TypeInfoPropertyName = "NullableReadSingleChartApiV1ChartsChartIdPostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType?), TypeInfoPropertyName = "NullableReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse?), TypeInfoPropertyName = "NullableUpdateChartApiV1ChartsChartIdPatchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType?), TypeInfoPropertyName = "NullableUpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ChartsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartSubSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartResponseSerialized>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsSectionResponse>))]
    internal sealed partial class ChartsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChartsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChartsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChartsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LangSmith.JsonConverters.ChartsItemJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostRequestJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostResponseJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.ReadSingleChartApiV1ChartsChartIdPostResponseJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.UpdateChartApiV1ChartsChartIdPatchResponseJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartType?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.DashboardLayoutInput, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?, double?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetric)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetric?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetricField)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetricField?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartType?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.HostProjectChartMetric)

                    || typeToConvert == typeof(global::LangSmith.HostProjectChartMetric?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy?)

                    || typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType)

                    || typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType?)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartCreateChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartCreateChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetric))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetric?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetricField))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetricField?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartResponseChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartResponseChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartsSectionChartDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartsSectionChartDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.HostProjectChartMetric))
                {
                    return new global::LangSmith.JsonConverters.HostProjectChartMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.HostProjectChartMetric?))
                {
                    return new global::LangSmith.JsonConverters.HostProjectChartMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupByAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupByAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType))
                {
                    return new global::LangSmith.JsonConverters.SingleCustomChartResponseSerializedChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType?))
                {
                    return new global::LangSmith.JsonConverters.SingleCustomChartResponseSerializedChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ChartsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}