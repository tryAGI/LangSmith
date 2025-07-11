#nullable enable

namespace LangSmith
{
    public partial interface IExperimentViewOverridesClient
    {
        /// <summary>
        /// Create new experiment view override configuration for a dataset<br/>
        /// Creates a new experiment view override configuration for a dataset with column display settings.<br/>
        /// This endpoint allows you to customize how experiment results are displayed by configuring<br/>
        /// column-specific overrides including colors, precision, and visibility.<br/>
        /// The request must include a 'column_overrides' array with at least one override configuration.<br/>
        /// Each column override can specify:<br/>
        /// - column: Required field name (must start with inputs, outputs, reference_outputs, feedback, metrics, attachments, or metadata)<br/>
        /// - color_gradient: Optional array of [number, color] tuples for numeric data visualization<br/>
        /// - precision: Optional number (1-6) for decimal places in numeric columns<br/>
        /// - hide: Optional boolean to control column visibility<br/>
        /// Example request body:<br/>
        /// {<br/>
        /// "column_overrides": [<br/>
        /// {<br/>
        /// "column": "outputs.accuracy",<br/>
        /// "color_gradient": [[0.0, "#ff0000"], [0.5, "#ffff00"], [1.0, "#00ff00"]],<br/>
        /// "precision": 3<br/>
        /// },<br/>
        /// {<br/>
        /// "column": "inputs.model_type",<br/>
        /// "hide": false<br/>
        /// }<br/>
        /// ]<br/>
        /// }<br/>
        /// This operation fails if an override already exists for the dataset (use PATCH to update).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> CreateNewExperimentViewOverrideConfigurationForADatasetAsync(
            global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create new experiment view override configuration for a dataset<br/>
        /// Creates a new experiment view override configuration for a dataset with column display settings.<br/>
        /// This endpoint allows you to customize how experiment results are displayed by configuring<br/>
        /// column-specific overrides including colors, precision, and visibility.<br/>
        /// The request must include a 'column_overrides' array with at least one override configuration.<br/>
        /// Each column override can specify:<br/>
        /// - column: Required field name (must start with inputs, outputs, reference_outputs, feedback, metrics, attachments, or metadata)<br/>
        /// - color_gradient: Optional array of [number, color] tuples for numeric data visualization<br/>
        /// - precision: Optional number (1-6) for decimal places in numeric columns<br/>
        /// - hide: Optional boolean to control column visibility<br/>
        /// Example request body:<br/>
        /// {<br/>
        /// "column_overrides": [<br/>
        /// {<br/>
        /// "column": "outputs.accuracy",<br/>
        /// "color_gradient": [[0.0, "#ff0000"], [0.5, "#ffff00"], [1.0, "#00ff00"]],<br/>
        /// "precision": 3<br/>
        /// },<br/>
        /// {<br/>
        /// "column": "inputs.model_type",<br/>
        /// "hide": false<br/>
        /// }<br/>
        /// ]<br/>
        /// }<br/>
        /// This operation fails if an override already exists for the dataset (use PATCH to update).
        /// </summary>
        /// <param name="columnOverrides"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> CreateNewExperimentViewOverrideConfigurationForADatasetAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride> columnOverrides,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}