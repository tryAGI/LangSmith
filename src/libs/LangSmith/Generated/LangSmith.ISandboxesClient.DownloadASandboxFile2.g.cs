#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Download a sandbox file<br/>
        /// Download file contents from a sandbox filesystem path. Supports HTTP range requests: send a Range header (for example `bytes=0-1023`) to receive a 206 with only that byte range. Every response carries an ETag; send it back as If-Range to resume safely (a changed file returns 200 with the whole file instead of mismatched bytes) or as If-None-Match to get a 304 when the file is unchanged. HEAD returns the same headers, including the file's size in Content-Length, without the body.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="path"></param>
        /// <param name="range"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadASandboxFile2Async(
            string sandboxId,
            string path,
            string? range = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download a sandbox file<br/>
        /// Download file contents from a sandbox filesystem path. Supports HTTP range requests: send a Range header (for example `bytes=0-1023`) to receive a 206 with only that byte range. Every response carries an ETag; send it back as If-Range to resume safely (a changed file returns 200 with the whole file instead of mismatched bytes) or as If-None-Match to get a 304 when the file is unchanged. HEAD returns the same headers, including the file's size in Content-Length, without the body.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="path"></param>
        /// <param name="range"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DownloadASandboxFile2AsStreamAsync(
            string sandboxId,
            string path,
            string? range = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download a sandbox file<br/>
        /// Download file contents from a sandbox filesystem path. Supports HTTP range requests: send a Range header (for example `bytes=0-1023`) to receive a 206 with only that byte range. Every response carries an ETag; send it back as If-Range to resume safely (a changed file returns 200 with the whole file instead of mismatched bytes) or as If-None-Match to get a 304 when the file is unchanged. HEAD returns the same headers, including the file's size in Content-Length, without the body.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="path"></param>
        /// <param name="range"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<byte[]>> DownloadASandboxFile2AsResponseAsync(
            string sandboxId,
            string path,
            string? range = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}