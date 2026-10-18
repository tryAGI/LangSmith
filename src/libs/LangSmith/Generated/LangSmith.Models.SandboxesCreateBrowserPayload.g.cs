
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesCreateBrowserPayload
    {
        /// <summary>
        /// HiDPI renders pages at twice the resolution, so the live view is sharp on<br/>
        /// HiDPI screens, at four times the pixels for the browser to render and<br/>
        /// stream. Off by default, and fixed once the browser is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidpi")]
        public bool? Hidpi { get; set; }

        /// <summary>
        /// IdleTTLSeconds stops the browser after this long without use. A stopped<br/>
        /// browser resumes with its memory on the next connection. Defaults to the<br/>
        /// sandbox default; 0 disables the idle stop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_ttl_seconds")]
        public int? IdleTtlSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mem_bytes")]
        public long? MemBytes { get; set; }

        /// <summary>
        /// Name of the browser sandbox. Generated when omitted, as "browser-"<br/>
        /// followed by the browser's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// VCPUs and MemBytes size the browser sandbox, as for any sandbox. With<br/>
        /// neither set, a browser gets 2 vCPUs and 8 GiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpus")]
        public long? Vcpus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateBrowserPayload" /> class.
        /// </summary>
        /// <param name="hidpi">
        /// HiDPI renders pages at twice the resolution, so the live view is sharp on<br/>
        /// HiDPI screens, at four times the pixels for the browser to render and<br/>
        /// stream. Off by default, and fixed once the browser is created.
        /// </param>
        /// <param name="idleTtlSeconds">
        /// IdleTTLSeconds stops the browser after this long without use. A stopped<br/>
        /// browser resumes with its memory on the next connection. Defaults to the<br/>
        /// sandbox default; 0 disables the idle stop.
        /// </param>
        /// <param name="memBytes"></param>
        /// <param name="name">
        /// Name of the browser sandbox. Generated when omitted, as "browser-"<br/>
        /// followed by the browser's ID.
        /// </param>
        /// <param name="vcpus">
        /// VCPUs and MemBytes size the browser sandbox, as for any sandbox. With<br/>
        /// neither set, a browser gets 2 vCPUs and 8 GiB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateBrowserPayload(
            bool? hidpi,
            int? idleTtlSeconds,
            long? memBytes,
            string? name,
            long? vcpus)
        {
            this.Hidpi = hidpi;
            this.IdleTtlSeconds = idleTtlSeconds;
            this.MemBytes = memBytes;
            this.Name = name;
            this.Vcpus = vcpus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateBrowserPayload" /> class.
        /// </summary>
        public SandboxesCreateBrowserPayload()
        {
        }

    }
}