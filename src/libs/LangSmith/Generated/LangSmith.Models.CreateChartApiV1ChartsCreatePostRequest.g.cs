#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateChartApiV1ChartsCreatePostRequest : global::System.IEquatable<CreateChartApiV1ChartsCreatePostRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType? ChartType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.CustomChartCreate? Line { get; init; }
#else
        public global::LangSmith.CustomChartCreate? Line { get; }
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
            out global::LangSmith.CustomChartCreate? value)
        {
            value = Line;
            return IsLine;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartCreate PickLine() => IsLine
            ? Line!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Line' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.CustomTextBlockCreate? Text { get; init; }
#else
        public global::LangSmith.CustomTextBlockCreate? Text { get; }
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
            out global::LangSmith.CustomTextBlockCreate? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockCreate PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateChartApiV1ChartsCreatePostRequest(global::LangSmith.CustomChartCreate value) => new CreateChartApiV1ChartsCreatePostRequest((global::LangSmith.CustomChartCreate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.CustomChartCreate?(CreateChartApiV1ChartsCreatePostRequest @this) => @this.Line;

        /// <summary>
        ///
        /// </summary>
        public CreateChartApiV1ChartsCreatePostRequest(global::LangSmith.CustomChartCreate? value)
        {
            Line = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateChartApiV1ChartsCreatePostRequest FromLine(global::LangSmith.CustomChartCreate? value) => new CreateChartApiV1ChartsCreatePostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateChartApiV1ChartsCreatePostRequest(global::LangSmith.CustomTextBlockCreate value) => new CreateChartApiV1ChartsCreatePostRequest((global::LangSmith.CustomTextBlockCreate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.CustomTextBlockCreate?(CreateChartApiV1ChartsCreatePostRequest @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public CreateChartApiV1ChartsCreatePostRequest(global::LangSmith.CustomTextBlockCreate? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateChartApiV1ChartsCreatePostRequest FromText(global::LangSmith.CustomTextBlockCreate? value) => new CreateChartApiV1ChartsCreatePostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateChartApiV1ChartsCreatePostRequest(
            global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType? chartType,
            global::LangSmith.CustomChartCreate? line,
            global::LangSmith.CustomTextBlockCreate? text
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
            global::System.Func<global::LangSmith.CustomChartCreate, TResult>? line = null,
            global::System.Func<global::LangSmith.CustomTextBlockCreate, TResult>? text = null,
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
            global::System.Action<global::LangSmith.CustomChartCreate>? line = null,

            global::System.Action<global::LangSmith.CustomTextBlockCreate>? text = null,
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
            global::System.Action<global::LangSmith.CustomChartCreate>? line = null,
            global::System.Action<global::LangSmith.CustomTextBlockCreate>? text = null,
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
                typeof(global::LangSmith.CustomChartCreate),
                Text,
                typeof(global::LangSmith.CustomTextBlockCreate),
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
        public bool Equals(CreateChartApiV1ChartsCreatePostRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.CustomChartCreate?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.CustomTextBlockCreate?>.Default.Equals(Text, other.Text)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateChartApiV1ChartsCreatePostRequest obj1, CreateChartApiV1ChartsCreatePostRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateChartApiV1ChartsCreatePostRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateChartApiV1ChartsCreatePostRequest obj1, CreateChartApiV1ChartsCreatePostRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateChartApiV1ChartsCreatePostRequest o && Equals(o);
        }
    }
}
