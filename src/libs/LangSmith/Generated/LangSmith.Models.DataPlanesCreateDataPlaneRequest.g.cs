#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DataPlanesCreateDataPlaneRequest : global::System.IEquatable<DataPlanesCreateDataPlaneRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAws? Aws { get; init; }
#else
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAws? Aws { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aws))]
#endif
        public bool IsAws => Aws != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAws(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.DataPlanesCreateDataPlaneRequestAws? value)
        {
            value = Aws;
            return IsAws;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAws PickAws() => Aws is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aws' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? Azure { get; init; }
#else
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? Azure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAzure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAzure PickAzure() => Azure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DataPlanesCreateDataPlaneRequest(global::LangSmith.DataPlanesCreateDataPlaneRequestAws value) => new DataPlanesCreateDataPlaneRequest((global::LangSmith.DataPlanesCreateDataPlaneRequestAws?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DataPlanesCreateDataPlaneRequestAws?(DataPlanesCreateDataPlaneRequest @this) => @this.Aws;

        /// <summary>
        ///
        /// </summary>
        public DataPlanesCreateDataPlaneRequest(global::LangSmith.DataPlanesCreateDataPlaneRequestAws? value)
        {
            Aws = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DataPlanesCreateDataPlaneRequest FromAws(global::LangSmith.DataPlanesCreateDataPlaneRequestAws? value) => new DataPlanesCreateDataPlaneRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DataPlanesCreateDataPlaneRequest(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure value) => new DataPlanesCreateDataPlaneRequest((global::LangSmith.DataPlanesCreateDataPlaneRequestAzure?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DataPlanesCreateDataPlaneRequestAzure?(DataPlanesCreateDataPlaneRequest @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public DataPlanesCreateDataPlaneRequest(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DataPlanesCreateDataPlaneRequest FromAzure(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? value) => new DataPlanesCreateDataPlaneRequest(value);

        /// <summary>
        ///
        /// </summary>
        public DataPlanesCreateDataPlaneRequest(
            global::LangSmith.DataPlanesCreateDataPlaneRequestAws? aws,
            global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? azure
            )
        {
            Aws = aws;
            Azure = azure;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Azure as object ??
            Aws as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aws?.ToString() ??
            Azure?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAws && !IsAzure || !IsAws && IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.DataPlanesCreateDataPlaneRequestAws, TResult>? aws = null,
            global::System.Func<global::LangSmith.DataPlanesCreateDataPlaneRequestAzure, TResult>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0 && aws != null)
            {
                return aws(__value0);
            }
            else if (Azure is { } __value1 && azure != null)
            {
                return azure(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.DataPlanesCreateDataPlaneRequestAws>? aws = null,

            global::System.Action<global::LangSmith.DataPlanesCreateDataPlaneRequestAzure>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.DataPlanesCreateDataPlaneRequestAws>? aws = null,
            global::System.Action<global::LangSmith.DataPlanesCreateDataPlaneRequestAzure>? azure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aws is { } __value0)
            {
                aws?.Invoke(__value0);
            }
            else if (Azure is { } __value1)
            {
                azure?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Aws,
                typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws),
                Azure,
                typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DataPlanesCreateDataPlaneRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DataPlanesCreateDataPlaneRequestAws?>.Default.Equals(Aws, other.Aws) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DataPlanesCreateDataPlaneRequestAzure?>.Default.Equals(Azure, other.Azure)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DataPlanesCreateDataPlaneRequest obj1, DataPlanesCreateDataPlaneRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataPlanesCreateDataPlaneRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DataPlanesCreateDataPlaneRequest obj1, DataPlanesCreateDataPlaneRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataPlanesCreateDataPlaneRequest o && Equals(o);
        }
    }
}
