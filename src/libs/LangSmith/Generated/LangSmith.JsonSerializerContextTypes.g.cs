
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIFeedbackSource? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyCreateRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyCreateResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AccessScope? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyGetResponse? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyUpdateRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddRepoOwnerRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddRunToQueueByKeyRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddRunToQueueRequest? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertThreshold? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertThresholdKind? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllowedLoginMethodsUpdate? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueBulkDeleteRunsRequest? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueCreateSchema? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRubricItemSchema? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditions? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackConfigSchema? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRunAddSchema? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TraceTier? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRunSchema? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRunUpdateSchema? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchema? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaQueueType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AssignedReviewerSchema>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AssignedReviewerSchema? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithRubric? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithRubricQueueType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithSize? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithSizeQueueType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSizeSchema? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchema? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AppFeedbackSource? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AttachmentsOperations? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogAgentAccessToken? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogAgentAccessTokenTrigger? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogAgentCheck? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogEnrichments? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogGateway? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogUpstream? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogServer? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogMessage? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogOperation? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthProvider? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AutoEvalFeedbackSource? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BasicAuthMemberCreate? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BasicAuthResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BasicAuthUserPatch? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyParamsForRunSchema? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunTypeEnum? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsFilterDataSourceTypeEnum? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSelect? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunDateOrder? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyParamsForRunsQuerySchema? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyDeleteRunsAbacApiV1RunsDeleteTracesPost? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyExecuteApiV1AceExecutePost? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyUploadExamplesFromCsvApiV1ExamplesUploadDatasetIdPost? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BotocoreS3Config? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BotocoreS3ConfigAddressingStyle? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExport? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportFormat? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportFormatVersion? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportCompression? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportStatus? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportCreate? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestination? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Config? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationCreate? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Credentials? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationUpdate? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRun? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunMetadata? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunStatus? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunMetadataExecutionBackend? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunProgress? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingUpload? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportUpdatableStatus? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportUpdate? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ChangePaymentPlanReq? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ChangePaymentPlanSchema? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ClusteringJobConfigResponse? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, string>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SavedRunClusteringJobRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CodeEvaluatorInputType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CodeEvaluatorLanguage? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CodeEvaluatorTopLevel? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Comment? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitManifestResponse? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoExampleResponse? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ComparativeExperiment? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SimpleExperimentInfo>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SimpleExperimentInfo? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ComparativeExperimentBase? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ComparativeExperimentCreate? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CompositeEvaluatorCreated? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CompositeMigrationRequest? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CompositeMigrationResult? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ConfiguredBy? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateClusteringJobConfigRequest? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunClusteringJobRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateClusteringJobConfigResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateCommentRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateFeedbackConfigSchema? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackConfig? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoRequest? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoRequestRepoType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoRequestSource? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookups? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRoleRequest? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunClusteringJobRequestModel? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunClusteringJobResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartCreate? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartCreateChartType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesCreate? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesFilters? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartCreatePreview? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesInput>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesInput? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackCountMetric? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackCountMetricParams? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricPercentile? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricPercentileParams? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricScalar? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricScalarParams? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFilterByDataset? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFilterByTracingProject? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartGroupByComplex? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartGroupByPlain? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetric? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricCount? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricField? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricPercentile? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricPercentileParams? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricRatioInput? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricScalar? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricRatioOutput? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartPreviewRequest? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsRequestBase? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartResponseChartType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesOutput>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesOutput? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HostProjectChartMetric? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBy? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesUpdate? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesV2Equivalent? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartUpdate? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsDataPoint? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<int?, double?, object>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TimedeltaInput? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSection? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ChartsItem>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ChartsItem? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerialized? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlock? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionChartDiscriminator? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionChartDiscriminatorChartType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartSubSectionResponse? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutOutput? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionCreate? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionRequest? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionUpdate? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutInput? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionsCloneRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockCreate? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomerVisiblePlanInfo? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PaymentPlanTier? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardBreakpointLayoutInput? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutRow>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutRow? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardBreakpointLayoutOutput? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutBreakpointsInput? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutBreakpointsOutput? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutItem? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutItem>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Dataset? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetTransformation? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetCreate? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetDiffInfo? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetPublicSchema? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetSchemaForUpdate? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetShareSchema? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetTransformationType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetUpdate? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleUpdate? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetVersion? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelQuestion? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelQuestionType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchema? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchemaTemplateFormat? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.DecisionModelQuestion>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchemaProvider? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteClusteringJobConfigResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteRunClusteringJobResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DemoConfig? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationAlgorithm? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobLogType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobStatus? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptWebhookTrigger? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluateExperimentRequest? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorFeedbackMapping? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultBody? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultBodyWindow? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorStructuredOutput? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorTopLevel? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Example? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleGroupWithSessions? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, int?, double?>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GroupedRunsSessionStats>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedRunsSessionStats? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleWithRunsCH? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleListOrder? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleSelect? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleUpdateWithID? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleValidationResult? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchemaComparisonView? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentProgress? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultRow? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchema? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultsUpload? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultsUploadResult? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSession? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExportAnnotationQueueRunsRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCategory? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<object, string>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceVariant12? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelFeedbackSource? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1Discriminator? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchema? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceVariant1? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1Discriminator? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateWithTokenExtendedSchema? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackDelta? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormula? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaAggregationType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaWeightedVariable? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaCreate? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaCreateAggregationType? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaUpdate? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaUpdateAggregationType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenCreateSchema? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenSchema? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackLevel? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSchema? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSource? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceParam? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackUpdateSchema? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FetchClusteringJobRunsResult? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterView? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewCreate? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewCreateType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewRename? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewUpdate? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewUpdateType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ForkRepoRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigRequest? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigRequestModel? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigResponse? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateSyntheticExamplesBody? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetClusteringJobConfigsResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ClusteringJobConfigResponse>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetDatasetsSelect? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRepoResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusterResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusteringJobResponse? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunCluster>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunCluster? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InsightsSummary? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusteringJobsResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunClusteringJobPydantic>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunClusteringJobPydantic? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetStartedPath? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageDimensions? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageGroupBy? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageKind? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageRecord? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageResponse? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageStride? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupExampleRunsByField? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedExamplesWithRunsResponse? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleGroupWithSessions>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedExperimentsRequest? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HTTPValidationError? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HealthInfoGetResponse? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HighlightedRun? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Identity? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityCreate? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityPatch? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InsightsSlackSettings? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InsightsSlackSettingsInput? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.HighlightedRun>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InternalSecretsResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InvokePromptPayload? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.LikeRepoRequest? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.LikeRepoResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListAuditLogOperationsResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListAuditLogsOCSFResponse? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OCSFApiActivity>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFApiActivity? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListCommentsResponse? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Comment>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPublicDatasetRunsResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunPublicDatasetSchema? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPublicRunsResponse? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunPublicSchema? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoOwnersResponse? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoOwner>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoOwner? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposResponse? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRunsResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchema>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchema? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourceRequest? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResourceType? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagCount>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagCount? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpToolsResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.MemberIdentity? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProviderUserSlim? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.MemberSortField? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapCreateSchema? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, string>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapListResponse? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapSchema? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapProviderSchema? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapProvidersResponse? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapProviderSchema>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapSchemaScope? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapUpdateSchema? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFActor? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUser? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFApi? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFClassName? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFCategoryName? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFMetadata? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFHttpRequest? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFHttpResponse? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFEndpoint? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OCSFResourceDetails>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFResourceDetails? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUnmapped? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUrl? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFProduct? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptJobRequest? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptimConfig? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptResponse? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgDefaultApplyTo? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgDefaultMonthlyTraceLimit? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertThreshold>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgUsage? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgUsageMetric? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgUsageMetricResponse? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgUsageMetricsResponse? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsageMetric>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Organization? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlusPlanTransitionInfo? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationRoles? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentity? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityPatch? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PermissionResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestSettingsType? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestScope? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseSettingsType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProblemDetails? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhook? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookBase? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookCreate? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookPayload? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookTest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookUpdate? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProvisioningMethod? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequest? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequestMethod? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRunsRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDeltaBatch? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryGroupedExamplesWithRuns? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QuerySessionFeedbackConfigIds? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueueInfoResponse? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RemoveRepoOwnerRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTag? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsRepoType? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsSource? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchema? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchemaSection? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Resource? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Role? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RoleRestrictionUpdate? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRule? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRuleOp? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionsJoin? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RubricItemConditionRule>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogsPaginatedResponse? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupBy? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupStats? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaInput? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitWindow? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaOutput? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchemaGroupBy? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchemaGroupBy? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchema? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchemaGroupBy? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchema? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchemaGroupBy? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunShareSchema? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStats? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupByAttribute? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseAttribute? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseSetBy? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParams? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsSelect? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParamsPublic? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationError? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationResponse? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProvider? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderType? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMapping? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SavedRunClusteringJobRequestModel? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfig? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigSource? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigInput? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretUpsert? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccount? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountWorkspaceAssignment? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIds? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIdsPage? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SessionFeedbackConfigIds>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerializedChartType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponseSerialized>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SourceType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeTaxId? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StudioRunOverDatasetRequestSchema? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMappingKey? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TTLSettings? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKey? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValue? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueCreate? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Tagging? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingCreate? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Tenant? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantCreate? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantForUser? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantMembers? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareThreadToken? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EntitiesItem? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantStats? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadEvaluatorSampleRequest? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadEvaluatorSampleResponse? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadMessagesFormatType? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadPreviewResponse? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyCreateRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyListResponse? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TrueFalseLiteral? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateClusteringJobConfigRequest? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateGetStartedPathRequest? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateOrgDefaultMonthlyTraceLimit? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobRequest? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobResponse? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitType? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitScope? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimit? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserOnboardingStateResponse? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserWithPassword? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ValidationError? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, int?>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceCreate? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceInviteResult? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspacePatch? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceSecret? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfig>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceSecretUpsert? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfigInput>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailLookupRequest? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddressesResolveResponse? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentCreateIssuesAgentRequest? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentGithubRepoInput>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentGithubRepoInput? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentErrorResponse? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentGithubRepo? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepohostProvider? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentIssuesAgent? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentIssuesAgentAnalysisLevel? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentGithubRepo>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearIntegration? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearSyncHealth? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetView? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentTargetAuthStatus? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearIntegrationPatch? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetInput? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetInputKind? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetViewKind? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentSaveOverviewRequest? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentSaveOverviewResponse? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentTargetAuthInput? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentUpdateIssuesAgentRequest? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgent? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentType? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentEnvironment>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentEnvironment? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentSourceType? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentCreate? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentEnvironmentName? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentRuntimeBinding>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentRuntimeBinding? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentListResponse? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgent>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentUpdate? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgreementAnswer? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgreementState? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertAction? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionTarget? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBase? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBaseTarget? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRule? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAggregation? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAttribute? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleOperator? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBase? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAggregation? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAttribute? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseOperator? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseType? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsCreateAlertRuleRequest? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsErrorResponse? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsUpdateAlertRuleRequest? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemInput? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItem>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItem? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerRequest? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemKeyAgreement? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueListItem? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.AnnotationqueuesItemKeyAgreement>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesItemKeyAgreement? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesDeleteAnnotationQueueItemsRequest? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesSetItemFinalRequest? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthSandboxDelegationMode? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnOrganizationConfig? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnPublicAuthInfo? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacAttributeName? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacOperator? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicy? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalConditionGroup? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicyCreateResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAttachAccessPoliciesPayload? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCondition? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalPermission? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCreateAccessPolicyPayload? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalListAccessPoliciesResponse? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalUpdateAccessPolicyPayload? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AwsResourceTag? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AzureResourceTag? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BackfillsRestartBackfillRequest? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitResponse? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsExampleRun? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitWithLookups? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitReq? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitResponse? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsListCommitsResponse? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneBYOIAMSettings? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMResourceNames? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettings? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettingsVariant1? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettingsVariant2? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequest? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAws? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestGCP? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneIngressSettings? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTraceStorage? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AzureResourceTag>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMSettings? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateErrorResponse? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneCloud? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFirewallSettings? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFleetOIDCSettings? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneProvisioningSettings? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTTLSettings? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesErrorResponse? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesMissingPermission>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesMissingPermission? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesListPublicDataPlanesResponse? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlane>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlane? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesStatus? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlaneWorkspace? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFirewallSettings? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFleetOIDCSettings? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneRequest? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsListDatasetsV2Response? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunSelectField? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsSort? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2ExampleWithRuns? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitInfo? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitResponse? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCreateDirectoryCommitRequest? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInput? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryGetDirectoryResponse? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.DirectoryDirectoryEntryOutput>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutput? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryErrorResponse? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersCreateRequest? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersListResponse? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EndusersUser>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersUser? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersUpdateRequest? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ErrutilUserError? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorsResponse? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluator? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluatorInput? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorBuildStatus? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorKey? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorRequest? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorType? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorResponse? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluator? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsErrorResponse? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsLLMEvaluator? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorRunRule? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendLimit? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsGetEvaluatorSpendResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendGroup>? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendGroup? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsListEvaluatorsResponse? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendDay? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendDay>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorRequest? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorResponse? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataRequest? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesMetadataOperation>? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperation? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataResponse? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatus? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesDeleteExamplesRequest? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesErrorResponse? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesCreatedResponse? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesDeletedResponse? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesUpdatedResponse? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperationOperation? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesColumnOverride? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverride? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesDisableModelRequest? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesErrorResponse? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesFeatureConfig? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesUpsertDefaultModelRequest? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsErrorResponse? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsValidationErrorResponse? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSubjectMatcher? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesGatewayPolicyRecord? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSpendUsage>? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSpendUsage? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesRateLimitUsage>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitUsage? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitMetric? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitWindow? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSearchGatewayPoliciesRequest? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesUpdateGatewayPolicyRequest? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesErrorResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HttperrErrorResponse? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsCreateEnvironmentsRequest? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsEnvironmentEntry? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsErrorResponse? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsHubEnvironmentsModel? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoBatchIngestConfig? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoCustomerInfo? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoInfoGetResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoSDKVersions? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationCatalogEntry? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverride? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverrideUpdate? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesErrorResponse? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidence? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesSeriesEvidence? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidenceType? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesFix? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssue? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerification? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesFix>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearContext? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSync? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesStatus? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueType? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResult? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerificationStatus? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResultOutcome? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSyncState? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesListViewsResponse? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesViewedIssue>? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesViewedIssue? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricDefinition? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountOrg? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountProject? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountResponseList? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsRequest? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsResponse? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsErrorResponse? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsGetMcpVendorResponse? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendorStatus? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpGatewaysResponse? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGateway? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpVendorsResponse? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendor? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListVendorToolsResponse? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsVendorTool>? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsVendorTool? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayBinding? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayToolFilter? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizationServerMetadata? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizedAppView? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientPublicMetadata? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationRequest? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationResponse? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthCreateOAuthClientRequest? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthDeviceCodeResponse? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientCredentialsResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientView? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientListResponse? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthOAuthClientView>? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOIDCProviderMetadata? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenErrorResponse? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenResponse? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUpdateOAuthClientRequest? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUserinfoResponse? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsLinkedLoginMethod? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsListOrgsResponse? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrg>? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrg? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrgMemberEnriched? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsLinkedLoginMethod>? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsSCIMGroup>? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsSCIMGroup? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsWorkspaceMembership? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationInfo? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationRole? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCategory? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackClientContext? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCreateRequest? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackSource? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackProductFeedback? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarification? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryAISearchClarificationOption>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarificationOption? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarificationOptionScope? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseRequestBody? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseRequestBodyScope? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseResponse? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseResponseScope? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBody? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsRequestBody? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunType? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsResponseBody? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTraceResponseBody? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesRequestBody? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesResponseBody? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTrace? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionCostDetails? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionTokenDetails? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunEvent? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunFeedbackStat? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptCostDetails? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptTokenDetails? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunStatus? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunURLResponse? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryStrideRequestBody? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryStrideUnit? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTraceAggregates? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlert? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlertSeverity? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlertType? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluator? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluatorCodeEvaluatorInput? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluatorLanguage? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesEvaluator? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesStructuredEvaluator? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesListResponse? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesRule>? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesRule? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesProblemDetails? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedParseErrorDetails? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesProblemDetailsErrorClass? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesAlert>? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesCodeEvaluator>? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesSpendLimit? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesEvaluator>? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesRuleGroupBy? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesWebhook>? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesWebhook? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesSpendLimitWindow? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsErrorResponse? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRun? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRunRunType? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsScalarMetricDefinition? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricEntity? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricField? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricParams? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricType? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsProjectUser? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsProjectUserStatsStatus? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsQueryUsersRequest? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsQueryUsersResponse? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsanalyticsProjectUser>? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobMountSpec? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubMountSpec? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiFileInfo? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSMountSpec? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpec? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpecType? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountSpec? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGrepMatch? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountCacheSpec? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountEncryptionSpec? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountKind? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpec? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3MountSpec? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3BucketMountSpec? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSBucketMountSpec? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitRepoMountSpec? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubRepoMountSpec? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobContainerMountSpec? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminator? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminatorType? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfig? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfigCredentials? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiRunConfig? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessControl? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessDelegation? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayload? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayloadController? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteRequest? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteResponse? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteSkipped? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachment? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachmentController? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserTab>? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserTab? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserResponse? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserAttachment>? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserWindowLinks? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCallback? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyHeader? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayload? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotImageConfig? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCloneVolumePayload? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserPayload? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyConfig? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserWindowLinksPayload? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayload? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayloadAuthType? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSandboxPayload? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountConfig? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountRequest>? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeMountRequest? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSnapshotPayload? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateVolumePayload? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayload? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLResponse? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponse? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponseDetail? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecRequest? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecResponse? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamRequest? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamResumeRequest? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobRequest? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobResponse? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepRequest? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepResponse? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiGrepMatch>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesHeaderType? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesLoadBrowserExtensionsResponse? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesOpenBrowserTabPayload? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSConfig? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSRoleConfig? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfig? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureConfig? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureAccountKeyConfig? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureSASConfig? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCallback>? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyRule? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPConfig? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPServiceAccountConfig? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyRuleMatchScheme? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxySecretValue? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryListResponse? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponse? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseAuthType? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseProvider? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseRepositorySearchMode? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountAuthConfig? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAuthConfig? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountAuthConfig? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxListResponse? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxResponse>? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxResponse? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountAuthConfig? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxVolumeResponse>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxVolumeResponse? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxStatusResponse? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCost? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageCostResourceType? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostTotals? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostsResponse? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDailyResponse? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageCost>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDaily? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageDaily>? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantListResponse? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesServiceURLGrantResponse>? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponse? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponseAccess? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayload? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayloadAccess? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponse? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponseAccess? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayload? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayloadController? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotListResponse? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponse? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameResponse? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotNameTag>? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameTag? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponseIncludedItem? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesStartSandboxPayload? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateBrowserAttachmentPayload? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayload? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayloadAuthType? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateSandboxPayload? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateVolumePayload? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUploadResponse? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageResponse? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrorDetail? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrors? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesValidationErrorDetail>? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeAttachmentResponse? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeListResponse? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeResponse>? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeResponse? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeAttachmentResponse>? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimCreateScimTokenPayload? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimErrorResponse? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenResponse? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenSensitiveResponse? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimUpdateScimTokenPayload? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsErrorResponse? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsListResponse? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsSecretItem>? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsSecretItem? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsBulkUpsertItem? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsPutRequest? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenRequestBody? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenResponseBody? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareDeleteShareTokenRequestBody? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetails? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetailsErrorClass? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryColumn? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryColumnDataType? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryRequest? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryResponse? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SqlqueryColumn>? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryResponseTruncationReason? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsErrorResponse? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransition? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransitionHistoryResponse? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsErrorResponse? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsListTenantsResponse? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantsTenant>? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsTenant? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsPublicSharedThreadTraceRunsResponseBody? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQuerySingleThreadStatsResponseBody? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsRequestBody? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsSelectField>? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadStatsSelectField? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsResponseBody? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsBucket>? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadStatsBucket? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadTracesResponseBody? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadTraceListItem>? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceListItem? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsRequestBody? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsResponseBody? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadListItem? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxActivationProblem? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxRef? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxScope? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxStatus? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSingleThreadStatsSelectField? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceSelectField? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareCreateShareTokenRequestBody? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareShareTokenResponseBody? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareThreadManifest? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsCreateToolPayload? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsErrorResponse? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsListToolsResponse? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsTool? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsUpdateToolPayload? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhook? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WebhooksSlackHandoffResponse? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsAgentVersionResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequest? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequestType? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsListSessionsV2Response? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Session>? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Session? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsUpdateSessionRequest? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsUpdateSessionRequestTraceTier? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsTTLSettingsResponse? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsUpdateTTLSettingsRequest? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageAgentUsagePage? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicAgentUsage>? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicAgentUsage? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicUserUsage? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageUserUsagePage? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicUserUsage>? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAddUserGroupMembersPayload? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAddUserGroupMembersResponse? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupMemberStatus>? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMemberStatus? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAttachUserGroupAccessPolicyPayload? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsCreateUserGroupPayload? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsCreateUserGroupWorkspaceGrantPayload? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupAccessPoliciesResponse? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupAccessPolicy>? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupAccessPolicy? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupMembersResponse? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupMember>? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMember? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupWorkspaceGrantsResponse? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupWorkspaceGrant? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupWorkspaceMembersResponse? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupWorkspaceMember>? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupWorkspaceMember? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupsResponse? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupListItem>? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupListItem? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUpdateUserGroupPayload? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUpdateUserGroupWorkspaceGrantPayload? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroup? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupAccessPolicyEffect? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMemberStatusStatus? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersErrorResponse? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersListResponse? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsersUser>? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUser? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUserRef? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelector? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelectorType? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelector? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelectorType? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelector? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminator? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminatorType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInput? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInputType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInput? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInputType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntry? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntryType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminator? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutput? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutputType? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutput? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutputType? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEvent? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEventEvent? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackStat? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackStatType? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionTraceTier? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SessionFeedbackStat>? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionType? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExampleApiV1ExamplesPostRequest? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchRequest? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsMultipartRequest? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueByKeyRequest>? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequest? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformDatasetsExamplesRequest? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformDatasetsExamplesRequest? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateSandboxesUploadRequest? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateAwsMarketplaceRegisterRequest? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthAuthorizeApproveRequest? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceAuthorizeRequest? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceCodeRequest? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthRevokeRequest? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthTokenRequest? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsBulkUpsertItem>? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuditLogOperation>? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadFilterViewsApiV1SessionsSessionIdViewsGetType? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSource? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortField? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortBy? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortOrder? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSourceType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsInclude? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsStatus? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsItemType? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsDirection? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsAgreement? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsCountAgreement? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformHubReposDirectoriesRepoType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesStatus? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesActivityItem? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesSortBy? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsKind? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsEnvironment? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetDatasetsSortOrder? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRunRulesType? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetRunsSelect>? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsSelect? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsResourceType? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsGranularity? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2TypeItem? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortBy? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortOrder? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortByFeedbackSource? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsStatsSelect>? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsStatsSelect? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsTracesSelect>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsTracesSelect? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetTracesRunsSelect>? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTracesRunsSelect? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetOrgsCurrentDataPlanesView? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortBy? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortOrder? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortBy? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortOrder? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateWorkspaceApiV1WorkspacesPostResponse2>? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateWorkspaceApiV1WorkspacesPostResponse2? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse2>? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse2? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteWorkspaceApiV1WorkspacesWorkspaceIdDeleteResponse3>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteWorkspaceApiV1WorkspacesWorkspaceIdDeleteResponse3? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetCurrentWorkspaceStatsApiV1WorkspacesCurrentStatsGetResponse2>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceStatsApiV1WorkspacesCurrentStatsGetResponse2? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2>? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse3>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse3? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceSecret>? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsGetResponse2>? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsGetResponse2? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpsertCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsPostResponse3>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsPostResponse3? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.PutCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyPutResponse2>? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PutCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyPutResponse2? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyDeleteResponse2>? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyDeleteResponse2? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetResponse2>? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetResponse2? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTagKeyApiV1WorkspacesCurrentTagKeysPostResponse2>? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTagKeyApiV1WorkspacesCurrentTagKeysPostResponse2? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse2>? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse2? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdGetResponse2>? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdGetResponse2? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdDeleteResponse2>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdDeleteResponse2? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse2>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse2? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagValuesApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesGetResponse2>? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagValuesApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesGetResponse2? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdGetResponse2>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdGetResponse2? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdPatchResponse2>? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdPatchResponse2? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse2>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse2? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTaggingApiV1WorkspacesCurrentTaggingsPostResponse2>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTaggingApiV1WorkspacesCurrentTaggingsPostResponse2? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTaggingsApiV1WorkspacesCurrentTaggingsGetResponse2>? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTaggingsApiV1WorkspacesCurrentTaggingsGetResponse2? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTaggingApiV1WorkspacesCurrentTaggingsTaggingIdDeleteResponse3>? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTaggingApiV1WorkspacesCurrentTaggingsTaggingIdDeleteResponse3? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsApiV1WorkspacesCurrentTagsGetResponse2>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsApiV1WorkspacesCurrentTagsGetResponse2? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse2>? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse2? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsForResourcesApiV1WorkspacesCurrentTagsResourcesPostResponse3>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourcesApiV1WorkspacesCurrentTagsResourcesPostResponse3? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchRunsResponse3? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsResponse3? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchResponse3? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormula>? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponse? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tenant>? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceInviteResult>? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListReposApiV1ReposGetResponse2>? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetResponse2? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateRepoApiV1ReposPostResponse2>? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoApiV1ReposPostResponse2? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteReposApiV1ReposDeleteResponse3>? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteReposApiV1ReposDeleteResponse3? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2>? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3>? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2>? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2>? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformAlertsTestResponse3? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformAlertsResponse3? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformAlertsResponse3? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeaturesFeatureConfig>? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentIssuesAgent>? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthAuthorizedAppView>? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? Type1623 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRubricItemSchema>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AssignedReviewerSchema>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSelect>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoExampleResponse>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SimpleExperimentInfo>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesCreate>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesInput>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesOutput>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsSection>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ChartsItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartSubSectionResponse>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutRow>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, object>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GroupedRunsSessionStats>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleWithRunsCH>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchemaComparisonView>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackCreateCoreSchema>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentResultRow>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackCategory>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackFormulaWeightedVariable>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ClusteringJobConfigResponse>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunCluster>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunClusteringJobPydantic>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GranularUsageRecord>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleGroupWithSessions>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.HighlightedRun>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OCSFApiActivity>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Comment>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunPublicDatasetSchema>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunPublicSchema>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoOwner>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoWithLookups>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchema>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagCount>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ProviderUserSlim>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ModelPriceMapSchema>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ModelPriceMapProviderSchema>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OCSFResourceDetails>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertThreshold>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgUsage>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgUsageMetric>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgMemberIdentity>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgPendingIdentity>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationResult>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJobLog>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EPromptWebhookTrigger>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.List<global::System.Guid>>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsGenerateQueryFeedbackKeys>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RubricItemConditionRule>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RuleLogSchema>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorTopLevel>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CodeEvaluatorTopLevel>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesPagerdutyAlertSchema>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesWebhookSchema>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunStatsSelect>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsQueryValidationError>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccountWorkspaceAssignment>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SessionFeedbackConfigIds>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsDataPoint>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartResponseSerialized>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValue>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValueWithTaggings>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Tagging>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Resource>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.MemberIdentity>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EntitiesItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.APIKeyGetResponse>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, int?>>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretConfig>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretConfigInput>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretUpsert>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentGithubRepoInput>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentGithubRepo>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgentEnvironment>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgentRuntimeBinding>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgent>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertsAlertAction>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertsAlertActionBase>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItem>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalConditionGroup>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalCondition>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalAccessPolicy>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CommitsExampleRun>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CommitsCommitWithLookups>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AwsResourceTag>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AzureResourceTag>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesMissingPermission>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlane>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Dataset>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunSelectField>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetsV2ExampleWithRuns>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunResponse>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EndusersUser>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluatorRunRule>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendGroup>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluator>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendDay>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesMetadataOperation>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesColumnOverride>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSubjectMatcher>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSpendUsage>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesRateLimitUsage>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.HubEnvironmentsEnvironmentEntry>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationCatalogEntry>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverride>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesFix>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesViewedIssue>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountOrg>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountProject>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpGateway>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpVendor>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsVendorTool>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthOAuthClientView>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrg>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsLinkedLoginMethod>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsSCIMGroup>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsWorkspaceMembership>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryAISearchClarificationOption>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryTrace>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunEvent>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesRule>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesAlert>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesCodeEvaluator>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesEvaluator>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesWebhook>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsanalyticsProjectUser>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBatchDeleteSkipped>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserTab>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserAttachment>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyHeader>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeMountRequest>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiFileInfo>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiGrepMatch>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCallback>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyRule>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesRegistryResponse>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxResponse>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiMountSpec>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxVolumeResponse>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageCost>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageDaily>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesServiceURLGrantResponse>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponse>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotNameTag>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesValidationErrorDetail>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeResponse>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeAttachmentResponse>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsSecretItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SqlqueryColumn>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagTransitionsTagTransition>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantsTenant>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadStatsSelectField>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadStatsBucket>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadTraceListItem>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadListItem>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ToolsTool>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Session>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicAgentUsage>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicUserUsage>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupMemberStatus>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupAccessPolicy>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupMember>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupWorkspaceMember>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupListItem>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsersUser>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListTagsForResourceRequest>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleUpdateWithID>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsRun>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueByKeyRequest>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BasicAuthMemberCreate>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsBulkUpsertItem>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuditLogOperation>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleSelect>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DataType>, global::LangSmith.DataType?>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataType>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetDatasetsSelect>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadMessagesFormatType>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Guid?>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SourceType>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetPlatformIssuesActivityItem>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetRunsSelect>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListSessionsV2TypeItem>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsStatsSelect>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsTracesSelect>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetTracesRunsSelect>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSession>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantForUser>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceSecret>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKey>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TaggingsResponse>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValues>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TTLSettings>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FilterView>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Example>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleValidationResult>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetVersion>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesSchema>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackFormula>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackSchema>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PublicComparativeExperiment>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchemaWithSize>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunSchema>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchema>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExport>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportDestination>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportRun>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackConfigSchema>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptWebhook>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PlaygroundSettingsResponse>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsSectionResponse>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrganizationPGSchemaSlim>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Role>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PermissionResponse>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserWithPassword>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProvider>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProviderSlim>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccount>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Tenant>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceInviteResult>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsageLimit>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoTag>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJob>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeaturesFeatureConfig>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesIssue>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentIssuesAgent>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthAuthorizedAppView>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrgMemberEnriched>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ScimScimTokenResponse>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSessionsAgentVersionResponse>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? ListType274 { get; set; }
    }
}