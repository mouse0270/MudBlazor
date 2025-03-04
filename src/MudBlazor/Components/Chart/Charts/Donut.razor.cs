﻿using System.Globalization;
using Microsoft.AspNetCore.Components;

#nullable enable
namespace MudBlazor.Charts
{
    /// <summary>
    /// Represents a chart which displays values as ring shape.
    /// </summary>
    /// <seealso cref="Bar"/>
    /// <seealso cref="Line"/>
    /// <seealso cref="Pie"/>
    /// <seealso cref="StackedBar"/>
    /// <seealso cref="TimeSeries"/>
    partial class Donut : MudCategoryChartBase
    {
        /// <summary>
        /// The chart, if any, containing this component.
        /// </summary>
        [CascadingParameter]
        public MudChart? MudChartParent { get; set; }

        private List<SvgCircle> _circles = [];
        private List<SvgLegend> _legends = [];

        protected string? ParentWidth => MudChartParent?.Width;
        protected string? ParentHeight => MudChartParent?.Height;

        /// <inheritdoc />
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            _circles.Clear();
            _legends.Clear();
            const double counterClockwiseOffset = 25;
            double totalPercent = 0;

            var counter = 0;
            foreach (var data in GetNormalizedData())
            {
                var percent = data * 100;
                var reversePercent = 100 - percent;
                var offset = 100 - totalPercent + counterClockwiseOffset;
                totalPercent += percent;

                var circle = new SvgCircle()
                {
                    Index = counter,
                    CX = 21,
                    CY = 21,
                    Radius = 100 / (2 * Math.PI),
                    StrokeDashArray = $"{ToS(percent)} {ToS(reversePercent)}",
                    StrokeDashOffset = offset
                };
                _circles.Add(circle);

                var labels = counter < InputLabels.Length ? InputLabels[counter] : "";
                var legend = new SvgLegend()
                {
                    Index = counter,
                    Labels = labels,
                    Data = data.ToString()
                };
                _legends.Add(legend);

                counter += 1;
            }
        }
    }
}
