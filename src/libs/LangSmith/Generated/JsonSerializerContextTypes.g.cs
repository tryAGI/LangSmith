
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
        public global::LangSmith.AnnotationQueueCreateSchema? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRubricItemSchema? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRunSchema? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRunUpdateSchema? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchema? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithRubric? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithSize? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSizeSchema? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchema? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppFeedbackSource? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Artifact? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ArtifactContent>? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ArtifactContent? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AttachmentsOperations? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AuthProvider? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AutoEvalFeedbackSource? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthMemberCreate? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthResponse? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthUserPatch? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestConfig? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyParamsForRunSchema? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunTypeEnum? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsFilterDataSourceTypeEnum? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSelect? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunDateOrder? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyExecuteApiV1AceExecutePost? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DataType? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExport? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportFormat? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportCompression? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportStatus? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportCreate? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestination? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationType? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Config? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationCreate? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Credentials? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRun? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunMetadata? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunProgress? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunStatus? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportUpdate? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportUpdateStatus? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChangePaymentPlanReq? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChangePaymentPlanSchema? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessage? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageType? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageChunk? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageChunkType? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CodeEvaluatorTopLevel? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Comment? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CommitManifestResponse? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoExampleResponse? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CommitWithLookups? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperiment? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SimpleExperimentInfo>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SimpleExperimentInfo? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperimentBase? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperimentCreate? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ConfiguredBy? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateCommentRequest? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateEventRequest? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateEventRequestEventType? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateFeedbackConfigSchema? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackConfig? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackType? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCategory? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoCommitRequest? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoCommitResponse? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoRequest? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoResponse? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoWithLookups? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRoleRequest? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartCreate? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartType? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesCreate? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesFilters? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartMetric? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartCreatePreview? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeries>? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeries? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartPreviewRequest? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsRequestBase? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TimedeltaInput? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartResponse? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesUpdate? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartUpdate? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Missing? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MissingMissing1? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsDataPoint? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<int?, double?, object>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsRequest? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsResponse? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSection? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponse>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartResponse? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionCreate? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionResponse? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionUpdate? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomerVisiblePlanInfo? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PaymentPlanTier? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Dataset? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformation? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformationType? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetCreate? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetDiffInfo? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexInfo? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexRequest? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetPublicSchema? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetSchemaForUpdate? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetShareSchema? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetUpdate? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdate? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetVersion? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DemoConfig? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationAlgorithm? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobLogType? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobStatus? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorStructuredOutput? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorTopLevel? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Example? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleListOrder? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleRunWithFeedback? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleSelect? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdateWithID? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleValidationResult? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRuns? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchema>? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchema? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TraceTier? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRunsCH? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaComparisonView? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultRow? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchema? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?>? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<object, string>? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource>? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelFeedbackSource? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUpload? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUploadResult? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSession? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackConfigSchema? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateSchema? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateWithTokenExtendedSchema? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackDelta? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenCreateSchema? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenSchema? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackLevel? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSchema? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSource3? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackUpdateSchema? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterQueryParamsForRunSchema? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterView? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewCreate? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewUpdate? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ForkRepoRequest? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessage? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageType? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunk? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunkType? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GenerateSyntheticExamplesBody? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GetRepoResponse? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HTTPValidationError? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ValidationError>? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ValidationError? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, int?>? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HealthInfoGetResponse? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Highlight? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessage? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageType? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunk? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunkType? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Identity? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityCreate? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityPatch? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InfoGetResponse? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvokePromptPayload? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoRequest? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoResponse? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommentsResponse? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Comment>? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommitsResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitWithLookups>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicDatasetRunsResponse? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicDatasetSchema? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string?>? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicRunsResponse? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicSchema? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposResponse? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRunsResponse? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListTagsResponse? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagCount>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagCount? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MemberIdentity? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ProviderUserSlim? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MetadataKeyValue? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapCreateSchema? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, string>? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapUpdateSchema? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorBlock? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorGroupSpec? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorRequest? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MonitorGroupSpec>? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MonitorResponse? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MonitorBlock>? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OAuthProvider? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptJobRequest? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptimConfig? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptRequest? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleRunWithFeedback>? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Organization? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Wallet? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentity? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PermissionResponse? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayload? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MessagesItem>? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MessagesItem? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessage? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageType? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessage? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageType? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageStatus? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunk? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunkType? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunk? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkType? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkStatus? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminator? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundRunOverDatasetRequestSchema? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunnableConfig? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<object>, object>? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTag? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Resource? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResourceType? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Role? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupBy? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupStats? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunShareSchema? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStats? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProvider? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetRequest? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetResponse? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SearchedFewShotExample>? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchedFewShotExample? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretKey? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretUpsert? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccount? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SourceType? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeAccountLinksCreate? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeTaxId? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsConfirm? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TTLSettings? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKey? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValue? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Tagging? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueCreate? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingCreate? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantCreate? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantForUser? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantMembers? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetTokenType? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunTokenType? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EntitiesItem? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantStats? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimitType? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimit? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UserWithPassword? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspaceCreate? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspacePatch? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppHubCrudOptimizeOptimizePromptResponse? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppHubCrudTenantsTenant? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppSchemasOptimizePromptResponse? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppSchemasTenant? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRunRequest? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRunRequestRunType? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OneOf<string, double?>? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequest? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPostItem>? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequestPostItem? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequestPostItemRunType? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPatchItem>? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestRunsRequestPatchItem? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRunRequest? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsPublic? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsPublic? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ComparativeExperiment>? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretKey>? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type546 { get; set; }
    }
}