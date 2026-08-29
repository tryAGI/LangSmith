#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ReadSingleChartApiV1ChartsChartIdPostResponse : global::System.IEquatable<ReadSingleChartApiV1ChartsChartIdPostResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SingleCustomChartResponseSerialized? SingleCustomChartResponseSerialized { get; init; }
#else
        public global::LangSmith.SingleCustomChartResponseSerialized? SingleCustomChartResponseSerialized { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SingleCustomChartResponseSerialized))]
#endif
        public bool IsSingleCustomChartResponseSerialized => SingleCustomChartResponseSerialized != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSingleCustomChartResponseSerialized(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SingleCustomChartResponseSerialized? value)
        {
            value = SingleCustomChartResponseSerialized;
            return IsSingleCustomChartResponseSerialized;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerialized PickSingleCustomChartResponseSerialized() => IsSingleCustomChartResponseSerialized
            ? SingleCustomChartResponseSerialized!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SingleCustomChartResponseSerialized' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.CustomTextBlockResponse? Text { get; init; }
#else
        public global::LangSmith.CustomTextBlockResponse? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.CustomTextBlockResponse? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockResponse PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReadSingleChartApiV1ChartsChartIdPostResponse(global::LangSmith.SingleCustomChartResponseSerialized value) => new ReadSingleChartApiV1ChartsChartIdPostResponse((global::LangSmith.SingleCustomChartResponseSerialized?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SingleCustomChartResponseSerialized?(ReadSingleChartApiV1ChartsChartIdPostResponse @this) => @this.SingleCustomChartResponseSerialized;

        /// <summary>
        ///
        /// </summary>
        public ReadSingleChartApiV1ChartsChartIdPostResponse(global::LangSmith.SingleCustomChartResponseSerialized? value)
        {
            SingleCustomChartResponseSerialized = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReadSingleChartApiV1ChartsChartIdPostResponse FromSingleCustomChartResponseSerialized(global::LangSmith.SingleCustomChartResponseSerialized? value) => new ReadSingleChartApiV1ChartsChartIdPostResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReadSingleChartApiV1ChartsChartIdPostResponse(global::LangSmith.CustomTextBlockResponse value) => new ReadSingleChartApiV1ChartsChartIdPostResponse((global::LangSmith.CustomTextBlockResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.CustomTextBlockResponse?(ReadSingleChartApiV1ChartsChartIdPostResponse @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ReadSingleChartApiV1ChartsChartIdPostResponse(global::LangSmith.CustomTextBlockResponse? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReadSingleChartApiV1ChartsChartIdPostResponse FromText(global::LangSmith.CustomTextBlockResponse? value) => new ReadSingleChartApiV1ChartsChartIdPostResponse(value);

        /// <summary>
        ///
        /// </summary>
        public ReadSingleChartApiV1ChartsChartIdPostResponse(
            global::LangSmith.SingleCustomChartResponseSerialized? singleCustomChartResponseSerialized,
            global::LangSmith.CustomTextBlockResponse? text
            )
        {
            SingleCustomChartResponseSerialized = singleCustomChartResponseSerialized;
            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Text as object ??
            SingleCustomChartResponseSerialized as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SingleCustomChartResponseSerialized?.ToString() ??
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSingleCustomChartResponseSerialized && !IsText || !IsSingleCustomChartResponseSerialized && IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.SingleCustomChartResponseSerialized, TResult>? singleCustomChartResponseSerialized = null,
            global::System.Func<global::LangSmith.CustomTextBlockResponse, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingleCustomChartResponseSerialized && singleCustomChartResponseSerialized != null)
            {
                return singleCustomChartResponseSerialized(SingleCustomChartResponseSerialized!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.SingleCustomChartResponseSerialized>? singleCustomChartResponseSerialized = null,

            global::System.Action<global::LangSmith.CustomTextBlockResponse>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingleCustomChartResponseSerialized)
            {
                singleCustomChartResponseSerialized?.Invoke(SingleCustomChartResponseSerialized!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.SingleCustomChartResponseSerialized>? singleCustomChartResponseSerialized = null,
            global::System.Action<global::LangSmith.CustomTextBlockResponse>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingleCustomChartResponseSerialized)
            {
                singleCustomChartResponseSerialized?.Invoke(SingleCustomChartResponseSerialized!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SingleCustomChartResponseSerialized,
                typeof(global::LangSmith.SingleCustomChartResponseSerialized),
                Text,
                typeof(global::LangSmith.CustomTextBlockResponse),
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
        public bool Equals(ReadSingleChartApiV1ChartsChartIdPostResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SingleCustomChartResponseSerialized?>.Default.Equals(SingleCustomChartResponseSerialized, other.SingleCustomChartResponseSerialized) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.CustomTextBlockResponse?>.Default.Equals(Text, other.Text)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReadSingleChartApiV1ChartsChartIdPostResponse obj1, ReadSingleChartApiV1ChartsChartIdPostResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReadSingleChartApiV1ChartsChartIdPostResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReadSingleChartApiV1ChartsChartIdPostResponse obj1, ReadSingleChartApiV1ChartsChartIdPostResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReadSingleChartApiV1ChartsChartIdPostResponse o && Equals(o);
        }
    }
}
