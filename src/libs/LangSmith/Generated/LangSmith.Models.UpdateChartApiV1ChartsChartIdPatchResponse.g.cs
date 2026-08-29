#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UpdateChartApiV1ChartsChartIdPatchResponse : global::System.IEquatable<UpdateChartApiV1ChartsChartIdPatchResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? ChartType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.CustomChartResponse? Line { get; init; }
#else
        public global::LangSmith.CustomChartResponse? Line { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Line))]
#endif
        public bool IsLine => Line != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLine(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.CustomChartResponse? value)
        {
            value = Line;
            return IsLine;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartResponse PickLine() => IsLine
            ? Line!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Line' but the value was {ToString()}.");

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
        public static implicit operator UpdateChartApiV1ChartsChartIdPatchResponse(global::LangSmith.CustomChartResponse value) => new UpdateChartApiV1ChartsChartIdPatchResponse((global::LangSmith.CustomChartResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.CustomChartResponse?(UpdateChartApiV1ChartsChartIdPatchResponse @this) => @this.Line;

        /// <summary>
        ///
        /// </summary>
        public UpdateChartApiV1ChartsChartIdPatchResponse(global::LangSmith.CustomChartResponse? value)
        {
            Line = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateChartApiV1ChartsChartIdPatchResponse FromLine(global::LangSmith.CustomChartResponse? value) => new UpdateChartApiV1ChartsChartIdPatchResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateChartApiV1ChartsChartIdPatchResponse(global::LangSmith.CustomTextBlockResponse value) => new UpdateChartApiV1ChartsChartIdPatchResponse((global::LangSmith.CustomTextBlockResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.CustomTextBlockResponse?(UpdateChartApiV1ChartsChartIdPatchResponse @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public UpdateChartApiV1ChartsChartIdPatchResponse(global::LangSmith.CustomTextBlockResponse? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateChartApiV1ChartsChartIdPatchResponse FromText(global::LangSmith.CustomTextBlockResponse? value) => new UpdateChartApiV1ChartsChartIdPatchResponse(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateChartApiV1ChartsChartIdPatchResponse(
            global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? chartType,
            global::LangSmith.CustomChartResponse? line,
            global::LangSmith.CustomTextBlockResponse? text
            )
        {
            ChartType = chartType;

            Line = line;
            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Text as object ??
            Line as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Line?.ToString() ??
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLine && !IsText || !IsLine && IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.CustomChartResponse, TResult>? line = null,
            global::System.Func<global::LangSmith.CustomTextBlockResponse, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLine && line != null)
            {
                return line(Line!);
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
            global::System.Action<global::LangSmith.CustomChartResponse>? line = null,

            global::System.Action<global::LangSmith.CustomTextBlockResponse>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLine)
            {
                line?.Invoke(Line!);
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
            global::System.Action<global::LangSmith.CustomChartResponse>? line = null,
            global::System.Action<global::LangSmith.CustomTextBlockResponse>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLine)
            {
                line?.Invoke(Line!);
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
                Line,
                typeof(global::LangSmith.CustomChartResponse),
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
        public bool Equals(UpdateChartApiV1ChartsChartIdPatchResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.CustomChartResponse?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.CustomTextBlockResponse?>.Default.Equals(Text, other.Text)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateChartApiV1ChartsChartIdPatchResponse obj1, UpdateChartApiV1ChartsChartIdPatchResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateChartApiV1ChartsChartIdPatchResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateChartApiV1ChartsChartIdPatchResponse obj1, UpdateChartApiV1ChartsChartIdPatchResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateChartApiV1ChartsChartIdPatchResponse o && Equals(o);
        }
    }
}
