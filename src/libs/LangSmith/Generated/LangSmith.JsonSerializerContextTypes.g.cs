
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
        public global::LangSmith.AllowedLoginMethodsUpdate? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueBulkDeleteRunsRequest? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueCreateSchema? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRubricItemSchema? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditions? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Missing? Type24 { get; set; }
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
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::LangSmith.Missing>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AppFeedbackSource? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AttachmentsOperations? Type45 { get; set; }
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
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsDataPoint? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<int?, double?, object>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsRequest? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TimedeltaInput? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsResponse? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSection? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ChartsItem>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ChartsItem? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerialized? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlock? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionChartDiscriminator? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionChartDiscriminatorChartType? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartSubSectionResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutOutput? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionCreate? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionUpdate? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.DashboardLayoutInput, global::LangSmith.Missing>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutInput? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionsCloneRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockCreate? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomerVisiblePlanInfo? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PaymentPlanTier? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardBreakpointLayoutInput? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutRow>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutRow? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardBreakpointLayoutOutput? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutBreakpointsInput? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutBreakpointsOutput? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutItem? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutItem>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Dataset? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetTransformation? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetCreate? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetDiffInfo? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetPublicSchema? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetSchemaForUpdate? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetShareSchema? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetTransformationType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetUpdate? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleUpdate? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetVersion? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelQuestion? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelQuestionType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchema? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchemaTemplateFormat? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.DecisionModelQuestion>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchemaProvider? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteClusteringJobConfigResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteRunClusteringJobResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DemoConfig? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationAlgorithm? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobLogType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobStatus? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptWebhookTrigger? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluateExperimentRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorFeedbackMapping? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultBody? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultBodyWindow? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorStructuredOutput? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorTopLevel? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Example? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleGroupWithSessions? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, int?, double?>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GroupedRunsSessionStats>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedRunsSessionStats? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleWithRunsCH? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleListOrder? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleSelect? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleUpdateWithID? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleValidationResult? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchemaComparisonView? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentProgress? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultRow? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchema? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultsUpload? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultsUploadResult? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSession? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExportAnnotationQueueRunsRequest? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCategory? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<object, string>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceVariant1? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelFeedbackSource? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1Discriminator? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchema? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceVariant12? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1Discriminator? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateWithTokenExtendedSchema? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackDelta? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormula? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaAggregationType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaWeightedVariable? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaCreate? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaCreateAggregationType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaUpdate? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaUpdateAggregationType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenCreateSchema? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenSchema? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackLevel? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSchema? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSource? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceParam? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackUpdateSchema? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FetchClusteringJobRunsResult? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterView? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewCreate? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewCreateType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewRename? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewType2? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewUpdate? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewUpdateType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ForkRepoRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigRequest? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigRequestModel? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateSyntheticExamplesBody? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetClusteringJobConfigsResponse? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ClusteringJobConfigResponse>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetDatasetsSelect? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRepoResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusterResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusteringJobResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunCluster>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunCluster? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InsightsSummary? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusteringJobsResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunClusteringJobPydantic>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunClusteringJobPydantic? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetStartedPath? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageDimensions? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageGroupBy? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageKind? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageRecord? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageStride? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupExampleRunsByField? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedExamplesWithRunsResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleGroupWithSessions>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedExperimentsRequest? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HTTPValidationError? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HealthInfoGetResponse? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HighlightedRun? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Identity? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityCreate? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityPatch? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.HighlightedRun>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InternalSecretsResponse? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InvokePromptPayload? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.LikeRepoRequest? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.LikeRepoResponse? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListAuditLogOperationsResponse? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListAuditLogsOCSFResponse? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OCSFApiActivity>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFApiActivity? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListCommentsResponse? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Comment>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPublicDatasetRunsResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunPublicDatasetSchema? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPublicRunsResponse? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunPublicSchema? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoOwnersResponse? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoOwner>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoOwner? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposResponse? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRunsResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchema>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchema? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourceRequest? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResourceType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsResponse? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagCount>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagCount? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpToolsResponse? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.MemberIdentity? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProviderUserSlim? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.MemberSortField? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapCreateSchema? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, string>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapListResponse? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapSchema? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapProviderSchema? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapProvidersResponse? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapProviderSchema>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapSchemaScope? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapTiersEnabledResponse? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapUpdateSchema? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFActor? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUser? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFApi? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFClassName? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFCategoryName? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFMetadata? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFHttpRequest? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFHttpResponse? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFEndpoint? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OCSFResourceDetails>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFResourceDetails? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUnmapped? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUrl? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFProduct? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptJobRequest? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptimConfig? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptResponse? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgUsage? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Organization? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlusPlanTransitionInfo? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationRoles? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentity? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityPatch? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PermissionResponse? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestSettingsType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestScope? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseSettingsType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProblemDetails? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhook? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookBase? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookCreate? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookPayload? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookTest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookUpdate? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProvisioningMethod? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequest? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequestMethod? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRunsRequest? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDeltaBatch? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryGroupedExamplesWithRuns? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QuerySessionFeedbackConfigIds? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueueInfoResponse? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RemoveRepoOwnerRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTag? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsRepoType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsSource? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchema? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchemaSection? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Resource? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Role? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RoleRestrictionUpdate? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRule? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRuleOp? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionsJoin? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RubricItemConditionRule>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogsPaginatedResponse? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupBy? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupStats? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaInput? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitWindow? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaOutput? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchemaGroupBy? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchemaGroupBy? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchema? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchemaGroupBy? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchema? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchemaGroupBy? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunShareSchema? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStats? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupByAttribute? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseAttribute? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseSetBy? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParams? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsSelect? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParamsPublic? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationError? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProvider? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderType? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMapping? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SavedRunClusteringJobRequestModel? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfig? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigSource? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigInput? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretUpsert? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccount? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountWorkspaceAssignment? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIds? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIdsPage? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SessionFeedbackConfigIds>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerializedChartType? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponseSerialized>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SourceType? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeTaxId? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StudioRunOverDatasetRequestSchema? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMappingKey? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TTLSettings? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKey? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValue? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueCreate? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Tagging? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingCreate? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantCreate? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantForUser? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantMembers? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareThreadToken? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EntitiesItem? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantStats? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadMessagesFormatType? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadPreviewResponse? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyCreateRequest? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyListResponse? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TrueFalseLiteral? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateClusteringJobConfigRequest? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateGetStartedPathRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobRequest? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobResponse? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitScope? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimit? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserOnboardingStateResponse? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserWithPassword? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ValidationError? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, int?>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceCreate? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceInviteResult? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspacePatch? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceSecret? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfig>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceSecretUpsert? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfigInput>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailLookupRequest? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AppHubCrudTenantsTenant? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AppSchemasTenant? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddressesResolveResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentCreateIssuesAgentRequest? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentGithubRepoInput>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentGithubRepoInput? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentErrorResponse? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentGithubRepo? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepohostProvider? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentIssuesAgent? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentIssuesAgentAnalysisLevel? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentGithubRepo>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearIntegration? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearSyncHealth? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetView? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentTargetAuthStatus? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearIntegrationPatch? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetInput? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetInputKind? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetViewKind? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentSaveOverviewRequest? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentSaveOverviewResponse? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentTargetAuthInput? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentUpdateIssuesAgentRequest? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgent? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentType? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentEnvironment>? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentEnvironment? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentSourceType2? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentCreate? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentEnvironmentName? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentRuntimeBinding>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentRuntimeBinding? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentListResponse? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgent>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentUpdate? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertAction? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionTarget? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBase? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBaseTarget? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRule? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAggregation? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAttribute? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleOperator? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleType? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBase? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAggregation? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAttribute? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseOperator? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseType? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleResponse? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsCreateAlertRuleRequest? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsErrorResponse? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsUpdateAlertRuleRequest? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemInput? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItem>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItem? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerRequest? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerResponse? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueListItem? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesDeleteAnnotationQueueItemsRequest? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthSandboxDelegationMode? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnOrganizationConfig? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnPublicAuthInfo? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacAttributeName? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacOperator? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicy? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalConditionGroup? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicyCreateResponse? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAttachAccessPoliciesPayload? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCondition? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalPermission? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCreateAccessPolicyPayload? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalListAccessPoliciesResponse? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalUpdateAccessPolicyPayload? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AwsResourceTag? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AzureResourceTag? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BackfillsRestartBackfillRequest? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitResponse? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsExampleRun? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitWithLookups? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitReq? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitResponse? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsListCommitsResponse? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneBYOIAMSettings? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMResourceNames? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAws? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestGCP? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTraceStorage? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AzureResourceTag>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateErrorResponse? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMSettings? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneCloud? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFirewallSettings? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFleetOIDCSettings? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneProvisioningSettings? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTTLSettings? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesErrorResponse? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesMissingPermission>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesMissingPermission? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesListPublicDataPlanesResponse? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlane>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlane? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesStatus? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlaneWorkspace? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFirewallSettings? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFleetOIDCSettings? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneRequest? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunSelectField? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsSort? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2ExampleWithRuns? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunResponse? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitInfo? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitResponse? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCreateDirectoryCommitRequest? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInput? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryGetDirectoryResponse? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.DirectoryDirectoryEntryOutput>? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutput? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryErrorResponse? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ErrutilUserError? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorsResponse? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluator? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluatorInput? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorBuildStatus? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorKey? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorRequest? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorType? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorResponse? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluator? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsErrorResponse? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsLLMEvaluator? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorRunRule? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendLimit? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsGetEvaluatorSpendResponse? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendGroup>? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendGroup? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsListEvaluatorsResponse? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendDay? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendDay>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorRequest? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorResponse? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataRequest? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesMetadataOperation>? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperation? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataResponse? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatus? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesDeleteExamplesRequest? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesErrorResponse? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesCreatedResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesDeletedResponse? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesUpdatedResponse? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperationOperation? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesColumnOverride? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverride? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesDisableModelRequest? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesErrorResponse? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesFeatureConfig? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesUpsertDefaultModelRequest? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsErrorResponse? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsValidationErrorResponse? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSubjectMatcher? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesGatewayPolicyRecord? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSpendUsage>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSpendUsage? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesRateLimitUsage>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitUsage? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitMetric? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitWindow? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSearchGatewayPoliciesRequest? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesUpdateGatewayPolicyRequest? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesErrorResponse? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HttperrErrorResponse? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsCreateEnvironmentsRequest? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsEnvironmentEntry? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsErrorResponse? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsHubEnvironmentsModel? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoBatchIngestConfig? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoCustomerInfo? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoInfoGetResponse? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoSDKVersions? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationCatalogEntry? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverride? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverrideUpdate? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesErrorResponse? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidence? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesSeriesEvidence? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidenceType? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesFix? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssue? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerification? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesFix>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearContext? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSync? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesStatus? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResult? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerificationStatus? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResultOutcome? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSyncState? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesListViewsResponse? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesViewedIssue>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesViewedIssue? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricDefinition? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountOrg? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountProject? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountResponseList? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsRequest? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsErrorResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsGetMcpVendorResponse? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendorStatus? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpGatewaysResponse? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGateway? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpVendorsResponse? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendor? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListVendorToolsResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsVendorTool>? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsVendorTool? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayBinding? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayToolFilter? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizationServerMetadata? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizedAppView? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientPublicMetadata? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationRequest? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthCreateOAuthClientRequest? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthDeviceCodeResponse? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientCredentialsResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientView? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientListResponse? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthOAuthClientView>? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOIDCProviderMetadata? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenErrorResponse? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenResponse? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUpdateOAuthClientRequest? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUserinfoResponse? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsLinkedLoginMethod? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsListOrgsResponse? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrg>? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrg? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrgMemberEnriched? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsLinkedLoginMethod>? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsSCIMGroup>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsSCIMGroup? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsWorkspaceMembership? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationInfo? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationRole? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCategory? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackClientContext? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCreateRequest? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackSource? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackProductFeedback? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBody? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsRequestBody? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunType? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsResponseBody? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTraceResponseBody? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesRequestBody? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesResponseBody? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTrace? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionCostDetails? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionTokenDetails? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunEvent? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunFeedbackStat? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptCostDetails? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptTokenDetails? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunStatus? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunURLResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTraceAggregates? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsErrorResponse? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRun? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRunRunType? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsScalarMetricDefinition? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricEntity? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricField? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricParams? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricType? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobMountSpec? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubMountSpec? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiFileInfo? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSMountSpec? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpec? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpecType? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountSpec? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGrepMatch? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountCacheSpec? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountEncryptionSpec? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountKind? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpec? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3MountSpec? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3BucketMountSpec? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSBucketMountSpec? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitRepoMountSpec? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubRepoMountSpec? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobContainerMountSpec? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminator? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminatorType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfig? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfigCredentials? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiRunConfig? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessControl? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessDelegation? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayload? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayloadController? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteRequest? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteResponse? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteSkipped? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachment? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachmentController? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserTab>? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserTab? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserResponse? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserAttachment>? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserWindowLinks? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCallback? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyHeader? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayload? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotImageConfig? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCloneVolumePayload? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserPayload? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyConfig? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserWindowLinksPayload? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayload? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayloadAuthType? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSandboxPayload? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountConfig? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountRequest>? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeMountRequest? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSnapshotPayload? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateVolumePayload? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayload? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLResponse? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponse? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponseDetail? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecRequest? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecResponse? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamRequest? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamResumeRequest? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobRequest? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobResponse? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepRequest? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepResponse? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiGrepMatch>? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesHeaderType? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesLoadBrowserExtensionsResponse? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesOpenBrowserTabPayload? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSConfig? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSRoleConfig? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfig? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureConfig? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureAccountKeyConfig? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureSASConfig? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCallback>? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyRule? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPConfig? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPServiceAccountConfig? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxySecretValue? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryListResponse? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponse? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseAuthType? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseProvider? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseRepositorySearchMode? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountAuthConfig? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAuthConfig? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountAuthConfig? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxListResponse? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxResponse>? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxResponse? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountAuthConfig? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxVolumeResponse>? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxVolumeResponse? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxStatusResponse? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCost? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageCostResourceType? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostTotals? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostsResponse? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDailyResponse? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageCost>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDaily? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageDaily>? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantListResponse? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesServiceURLGrantResponse>? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponse? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponseAccess? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayload? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayloadAccess? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponse? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponseAccess? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayload? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayloadController? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotListResponse? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponse? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameResponse? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotNameTag>? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameTag? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponseIncludedItem? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesStartSandboxPayload? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateBrowserAttachmentPayload? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayload? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayloadAuthType? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateSandboxPayload? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateVolumePayload? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUploadResponse? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageResponse? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrorDetail? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrors? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesValidationErrorDetail>? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeAttachmentResponse? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeListResponse? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeResponse>? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeResponse? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeAttachmentResponse>? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimCreateScimTokenPayload? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimErrorResponse? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenResponse? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenSensitiveResponse? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimUpdateScimTokenPayload? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsErrorResponse? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsListResponse? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsSecretItem>? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsSecretItem? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsBulkUpsertItem? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsPutRequest? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenRequestBody? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenResponseBody? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareDeleteShareTokenRequestBody? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedParseErrorDetails? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetails? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetailsErrorClass? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsErrorResponse? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransition? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransitionHistoryResponse? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsAddTeamMembersPayload? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsAddTeamMembersResponse? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TeamsTeamMemberStatus>? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamMemberStatus? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsAttachTeamAccessPolicyPayload? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsCreateTeamPayload? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsCreateTeamWorkspaceGrantPayload? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsListTeamAccessPoliciesResponse? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TeamsTeamAccessPolicy>? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamAccessPolicy? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsListTeamMembersResponse? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TeamsTeamMember>? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamMember? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsListTeamWorkspaceGrantsResponse? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TeamsTeamWorkspaceGrant>? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamWorkspaceGrant? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsListTeamWorkspaceMembersResponse? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TeamsTeamWorkspaceMember>? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamWorkspaceMember? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsListTeamsResponse? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TeamsTeamListItem>? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamListItem? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeam? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamAccessPolicyEffect? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsTeamMemberStatusStatus? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsUpdateTeamPayload? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TeamsUpdateTeamWorkspaceGrantPayload? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsErrorResponse? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsListTenantsResponse? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantsTenant>? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsTenant? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsPublicSharedThreadTraceRunsResponseBody? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQuerySingleThreadStatsResponseBody? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsRequestBody? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsSelectField>? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadStatsSelectField? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsResponseBody? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadTracesResponseBody? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadTraceListItem>? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceListItem? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsRequestBody? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsResponseBody? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadListItem? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxActivationProblem? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxRef? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxScope? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxStatus? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSingleThreadStatsSelectField? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceSelectField? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareCreateShareTokenRequestBody? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareShareTokenResponseBody? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareThreadManifest? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsCreateToolPayload? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsErrorResponse? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsListToolsResponse? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsTool? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsUpdateToolPayload? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhook? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WebhooksSlackHandoffResponse? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsAgentVersionResponse? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsTTLSettingsResponse? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsUpdateTTLSettingsRequest? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageAgentUsagePage? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicAgentUsage>? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicAgentUsage? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicUserUsage? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageUserUsagePage? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicUserUsage>? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersErrorResponse? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersListResponse? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsersUser>? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUser? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUserRef? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelector? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelectorType? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelector? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelectorType? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelector? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminator? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminatorType? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInput? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInputType? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInput? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInputType? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntry? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntryType? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminator? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutput? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutputType? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutput? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutputType? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEvent? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEventEvent? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExampleApiV1ExamplesPostRequest? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchRequest? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsMultipartRequest? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueByKeyRequest>? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequest? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformDatasetsExamplesRequest? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformDatasetsExamplesRequest? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateSandboxesUploadRequest? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateAwsMarketplaceRegisterRequest? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthAuthorizeApproveRequest? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceAuthorizeRequest? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceCodeRequest? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthRevokeRequest? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthTokenRequest? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsBulkUpsertItem>? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuditLogOperation>? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadFilterViewsApiV1SessionsSessionIdViewsGetType? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoType? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSource? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortField? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortBy? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortOrder? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSourceType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsInclude? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsStatus? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsItemType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsDirection? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformHubReposDirectoriesRepoType? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesStatus? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesActivityItem? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesSortBy? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsKind? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsEnvironment? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetRunsSelect>? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsSelect? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsResourceType? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsGranularity? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsStatsSelect>? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsStatsSelect? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsTracesSelect>? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsTracesSelect? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetTracesRunsSelect>? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTracesRunsSelect? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetOrgsCurrentDataPlanesView? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortBy? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortOrder? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortBy? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortOrder? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceSecret>? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchRunsResponse3? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsResponse3? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchResponse3? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormula>? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponse? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceInviteResult>? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListReposApiV1ReposGetResponse2>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetResponse2? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateRepoApiV1ReposPostResponse2>? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoApiV1ReposPostResponse2? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteReposApiV1ReposDeleteResponse3>? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteReposApiV1ReposDeleteResponse3? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2>? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3>? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2>? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2>? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2>? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformAlertsTestResponse3? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformAlertsResponse3? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformAlertsResponse3? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeaturesFeatureConfig>? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentIssuesAgent>? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthAuthorizedAppView>? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? Type1480 { get; set; }

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
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsSection>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ChartsItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartSubSectionResponse>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutRow>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, object>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GroupedRunsSessionStats>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleWithRunsCH>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchemaComparisonView>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackCreateCoreSchema>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentResultRow>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackCategory>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackFormulaWeightedVariable>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ClusteringJobConfigResponse>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunCluster>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunClusteringJobPydantic>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GranularUsageRecord>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleGroupWithSessions>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.HighlightedRun>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OCSFApiActivity>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Comment>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunPublicDatasetSchema>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunPublicSchema>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoOwner>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoWithLookups>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchema>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagCount>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ProviderUserSlim>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ModelPriceMapSchema>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ModelPriceMapProviderSchema>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OCSFResourceDetails>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgMemberIdentity>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgPendingIdentity>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationResult>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJobLog>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EPromptWebhookTrigger>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.List<global::System.Guid>>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsGenerateQueryFeedbackKeys>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RubricItemConditionRule>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RuleLogSchema>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorTopLevel>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CodeEvaluatorTopLevel>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesPagerdutyAlertSchema>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesWebhookSchema>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunStatsSelect>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsQueryValidationError>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccountWorkspaceAssignment>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SessionFeedbackConfigIds>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsDataPoint>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartResponseSerialized>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValue>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValueWithTaggings>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Tagging>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Resource>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.MemberIdentity>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EntitiesItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.APIKeyGetResponse>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, int?>>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretConfig>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretConfigInput>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentGithubRepoInput>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentGithubRepo>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgentEnvironment>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgentRuntimeBinding>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgent>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertsAlertAction>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertsAlertActionBase>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalConditionGroup>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalCondition>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalAccessPolicy>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CommitsExampleRun>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CommitsCommitWithLookups>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AwsResourceTag>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AzureResourceTag>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesMissingPermission>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlane>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunSelectField>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetsV2ExampleWithRuns>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunResponse>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluatorRunRule>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendGroup>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluator>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendDay>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesMetadataOperation>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesColumnOverride>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSubjectMatcher>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSpendUsage>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesRateLimitUsage>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.HubEnvironmentsEnvironmentEntry>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationCatalogEntry>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverride>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesFix>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesViewedIssue>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountOrg>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountProject>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpGateway>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpVendor>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsVendorTool>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthOAuthClientView>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrg>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsLinkedLoginMethod>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsSCIMGroup>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsWorkspaceMembership>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryTrace>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunEvent>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBatchDeleteSkipped>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserTab>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserAttachment>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyHeader>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeMountRequest>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiFileInfo>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiGrepMatch>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCallback>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyRule>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesRegistryResponse>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxResponse>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiMountSpec>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxVolumeResponse>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageCost>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageDaily>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesServiceURLGrantResponse>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponse>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotNameTag>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesValidationErrorDetail>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeResponse>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeAttachmentResponse>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsSecretItem>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagTransitionsTagTransition>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TeamsTeamMemberStatus>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TeamsTeamAccessPolicy>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TeamsTeamMember>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TeamsTeamWorkspaceGrant>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TeamsTeamWorkspaceMember>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TeamsTeamListItem>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantsTenant>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadStatsSelectField>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadTraceListItem>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadListItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ToolsTool>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicAgentUsage>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicUserUsage>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsersUser>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretUpsert>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListTagsForResourceRequest>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleUpdateWithID>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsRun>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueByKeyRequest>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BasicAuthMemberCreate>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsBulkUpsertItem>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuditLogOperation>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleSelect>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DataType>, global::LangSmith.DataType?>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataType>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetDatasetsSelect>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadMessagesFormatType>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Guid?>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SourceType>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetPlatformIssuesActivityItem>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetRunsSelect>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsStatsSelect>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsTracesSelect>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetTracesRunsSelect>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSession>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantForUser>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceSecret>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKey>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TaggingsResponse>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValues>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TTLSettings>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FilterView>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Example>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleValidationResult>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Dataset>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetVersion>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesSchema>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackFormula>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackSchema>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PublicComparativeExperiment>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchemaWithSize>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunSchema>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchema>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExport>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportDestination>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportRun>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackConfigSchema>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptWebhook>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PlaygroundSettingsResponse>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsSectionResponse>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrganizationPGSchemaSlim>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Role>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PermissionResponse>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserWithPassword>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProvider>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgUsage>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProviderSlim>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccount>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AppSchemasTenant>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceInviteResult>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsageLimit>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoTag>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJob>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeaturesFeatureConfig>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesIssue>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentIssuesAgent>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthAuthorizedAppView>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrgMemberEnriched>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ScimScimTokenResponse>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSessionsAgentVersionResponse>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? ListType260 { get; set; }
    }
}