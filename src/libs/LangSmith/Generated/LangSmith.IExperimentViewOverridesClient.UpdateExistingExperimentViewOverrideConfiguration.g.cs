#nullable enable

namespace LangSmith
{
    public partial interface IExperimentViewOverridesClient
    {
        /// <summary>
        /// Update existing experiment view override configuration<br/>
        /// Updates an existing experiment view override configuration by completely replacing<br/>
        /// the column overrides for the specified dataset and override ID.<br/>
        /// This endpoint performs a complete replacement of the column overrides configuration.<br/>
        /// All existing column overrides will be replaced with the new configuration provided<br/>
        /// in the request body. To add or modify individual columns, include the complete<br/>
        /// desired configuration in the request.<br/>
        /// The request format is identical to the create endpoint:<br/>
        /// - column_overrides: Required array with at least one override configuration<br/>
        /// - Each override can specify color gradients, precision, and visibility<br/>
        /// Example request body:<br/>
        /// {<br/>
        /// "column_overrides": [<br/>
        /// {<br/>
        /// "column": "metrics.f1_score",<br/>
        /// "color_gradient": [[0.0, "#ff4444"], [0.8, "#44ff44"]],<br/>
        /// "precision": 4<br/>
        /// },<br/>
        /// {<br/>
        /// "column": "feedback.rating",<br/>
        /// "hide": false<br/>
        /// }<br/>
        /// ]<br/>
        /// }<br/>
        /// Both the dataset and override must exist and be accessible by the authenticated user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> UpdateExistingExperimentViewOverrideConfigurationAsync(
            global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update existing experiment view override configuration<br/>
        /// Updates an existing experiment view override configuration by completely replacing<br/>
        /// the column overrides for the specified dataset and override ID.<br/>
        /// This endpoint performs a complete replacement of the column overrides configuration.<br/>
        /// All existing column overrides will be replaced with the new configuration provided<br/>
        /// in the request body. To add or modify individual columns, include the complete<br/>
        /// desired configuration in the request.<br/>
        /// The request format is identical to the create endpoint:<br/>
        /// - column_overrides: Required array with at least one override configuration<br/>
        /// - Each override can specify color gradients, precision, and visibility<br/>
        /// Example request body:<br/>
        /// {<br/>
        /// "column_overrides": [<br/>
        /// {<br/>
        /// "column": "metrics.f1_score",<br/>
        /// "color_gradient": [[0.0, "#ff4444"], [0.8, "#44ff44"]],<br/>
        /// "precision": 4<br/>
        /// },<br/>
        /// {<br/>
        /// "column": "feedback.rating",<br/>
        /// "hide": false<br/>
        /// }<br/>
        /// ]<br/>
        /// }<br/>
        /// Both the dataset and override must exist and be accessible by the authenticated user.
        /// </summary>
        /// <param name="columnOverrides"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> UpdateExistingExperimentViewOverrideConfigurationAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride> columnOverrides,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}