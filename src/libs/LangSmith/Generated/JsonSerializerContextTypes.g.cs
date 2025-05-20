
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessage? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, object>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessageType? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolCall>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCall? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCallType? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvalidToolCall? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvalidToolCallType? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageMetadata? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InputTokenDetails? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OutputTokenDetails? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessageChunk? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessageChunkType? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolCallChunk>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCallChunk? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCallChunkType? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIFeedbackSource? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIKeyCreateRequest? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIKeyCreateResponse? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIKeyGetResponse? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AccessScope? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllowedLoginMethodsUpdate? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueBulkDeleteRunsRequest? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueCreateSchema? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRubricItemSchema? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRunSchema? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRunUpdateSchema? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchema? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithRubric? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithSize? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSizeSchema? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchema? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppFeedbackSource? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Artifact? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ArtifactContent>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ArtifactContent? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AttachmentsOperations? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AuthProvider? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AutoEvalFeedbackSource? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthMemberCreate? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthResponse? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthUserPatch? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestConfig? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyParamsForRunSchema? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunTypeEnum? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsFilterDataSourceTypeEnum? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSelect? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunDateOrder? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyExecuteApiV1AceExecutePost? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyLegacyUploadExamplesApiV1ExamplesUploadDatasetIdPost? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DataType? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExport? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportFormat? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportCompression? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportStatus? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportCreate? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestination? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationType? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Config? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationCreate? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Credentials? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRun? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunMetadata? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunProgress? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunStatus? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportUpdate? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportUpdateStatus? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChangePaymentPlanReq? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChangePaymentPlanSchema? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessage? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageType? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageChunk? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageChunkType? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CodeEvaluatorTopLevel? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Comment? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CommitManifestResponse? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoExampleResponse? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CommitWithLookups? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperiment? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SimpleExperimentInfo>? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SimpleExperimentInfo? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperimentBase? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperimentCreate? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ConfiguredBy? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateCommentRequest? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateEventRequest? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateEventRequestEventType? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateFeedbackConfigSchema? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackConfig? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackType? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCategory? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoCommitRequest? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoCommitResponse? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoRequest? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoResponse? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoWithLookups? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRoleRequest? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartCreate? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartType? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesCreate? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesFilters? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartMetric? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBy? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupByAttribute? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartCreatePreview? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeries>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeries? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, string>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponse? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseAttribute? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseSetBy? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartPreviewRequest? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsRequestBase? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TimedeltaInput? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartResponse? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesUpdate? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartUpdate? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Missing? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MissingMissing1? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsDataPoint? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<int?, double?, object>? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsRequest? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsResponse? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSection? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponse>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartResponse? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartSubSectionResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionCreate? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionRequest? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionResponse? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionUpdate? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomerVisiblePlanInfo? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PaymentPlanTier? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Dataset? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformation? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformationType? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetCreate? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetDiffInfo? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexInfo? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexRequest? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetPublicSchema? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetSchemaForUpdate? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetShareSchema? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetUpdate? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdate? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetVersion? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DemoConfig? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationAlgorithm? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobLogType? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobStatus? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptWebhookTrigger? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorStructuredOutput? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorTopLevel? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Example? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleListOrder? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleSelect? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdateWithID? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleValidationResult? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRuns? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchema>? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchema? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TraceTier? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRunsCH? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaComparisonView? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRunsGroup? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultRow? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchema? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?>? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<object, string>? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource>? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelFeedbackSource? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUpload? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUploadResult? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSession? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExportAnnotationQueueRunsRequest? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackConfigSchema? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateSchema? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateWithTokenExtendedSchema? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackDelta? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenCreateSchema? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenSchema? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackLevel? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSchema? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSource3? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackUpdateSchema? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterView? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewType? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewCreate? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewUpdate? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ForkRepoRequest? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessage? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageType? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunk? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunkType? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GenerateSyntheticExamplesBody? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GetRepoResponse? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GroupExampleRunsByField? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GroupedExamplesWithRunsResponse? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsGroup>? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HTTPValidationError? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ValidationError>? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ValidationError? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, int?>? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HealthInfoGetResponse? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Highlight? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessage? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageType? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunk? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunkType? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Identity? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityCreate? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityPatch? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InfoGetResponse? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvokePromptPayload? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoRequest? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoResponse? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommentsResponse? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Comment>? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommitsResponse? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitWithLookups>? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicDatasetRunsResponse? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicDatasetSchema? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string?>? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicRunsResponse? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicSchema? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposResponse? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRunsResponse? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object?>? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListTagsForResourceRequest? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResourceType? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListTagsResponse? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagCount>? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagCount? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MemberIdentity? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ProviderUserSlim? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MetadataKeyValue? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapCreateSchema? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, string>? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapUpdateSchema? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorBlock? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorGroupSpec? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorRequest? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MonitorGroupSpec>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorResponse? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MonitorBlock>? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OAuthProvider? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptJobRequest? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptimConfig? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptResponse? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgUsage? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Organization? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Wallet? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentity? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PermissionResponse? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayload? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessage? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageType? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessage? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageType? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageStatus? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunk? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunkType? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunk? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkType? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkStatus? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundRunOverDatasetRequestSchema? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunnableConfig? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<object>, object>? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhook? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookBase? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookCreate? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookPayload? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookTest? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookUpdate? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRunsFormat? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryGroupedExamplesWithRuns? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTag? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Resource? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Role? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupBy? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupStats? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunShareSchema? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStats? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsQueryParams? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProvider? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetRequest? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetResponse? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SearchedFewShotExample>? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchedFewShotExample? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretKey? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretUpsert? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccount? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SourceType? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeAccountLinksCreate? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeTaxId? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsConfirm? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TTLSettings? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKey? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValue? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Tagging? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueCreate? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingCreate? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantCreate? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantForUser? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantMembers? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetTokenType? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunTokenType? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EntitiesItem? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantStats? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimitType? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimit? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UserWithPassword? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspaceCreate? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspacePatch? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppHubCrudTenantsTenant? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppSchemasTenant? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRunRequest? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRunRequestRunType? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OneOf<string, double?>? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequest? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPostItem>? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequestPostItem? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequestPostItemRunType? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPatchItem>? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequestPatchItem? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRunRequest? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request2? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request3? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsPublic? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsPublic? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ComparativeExperiment>? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretKey>? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response3>? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response3? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response6>? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response6? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response10>? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response10? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response13>? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response13? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response16>? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response16? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response19>? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response19? Type593 { get; set; }
    }
}