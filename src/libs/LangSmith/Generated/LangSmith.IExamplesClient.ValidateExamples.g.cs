#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Validate Examples<br/>
        /// Validate an example.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>> ValidateExamplesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}