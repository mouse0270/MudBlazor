// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Components;
using MudBlazor.Utilities;

namespace MudBlazor;

#nullable enable

/// <summary>
/// A component for aligning child items horizontally or vertically.
/// </summary>
public partial class MudStack : MudComponentBase
{
    protected string Classname =>
        new CssBuilder("d-flex")
            .AddClass($"flex-{(Row ? "row" : "column")}{(Reverse ? "-reverse" : string.Empty)}")
            .AddClass($"flex-{xs?.ToDescriptionString()}-xs", xs is not null)
            .AddClass($"flex-{sm?.ToDescriptionString()}-sm", sm is not null)
            .AddClass($"flex-{md?.ToDescriptionString()}-md", md is not null)
            .AddClass($"flex-{lg?.ToDescriptionString()}-lg", lg is not null)
            .AddClass($"flex-{xl?.ToDescriptionString()}-xl", xl is not null)
            .AddClass($"flex-{xxl?.ToDescriptionString()}-xxl", xxl is not null)
            .AddClass($"justify-{Justify?.ToDescriptionString()}", Justify is not null)
            .AddClass($"align-{AlignItems?.ToDescriptionString()}", AlignItems is not null)
            .AddClass($"flex-{Wrap?.ToDescriptionString()}", Wrap is not null)
            .AddClass($"gap-{Spacing}", Spacing >= 0)
            .AddClass($"flex-grow-{StretchItems?.ToDescriptionString()}", StretchItems is not null and not MudBlazor.StretchItems.None)
            .AddClass(Class)
            .Build();

    /// <summary>
    /// Displays items horizontally.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>false</c>.  
    /// When <c>true</c>, items will be displayed horizontally.  When <c>false</c>, items are displayed vertically.
    /// </remarks>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public bool Row { get; set; }

    /// <summary>
    /// Reverses the order of items.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>false</c>.  
    /// When <c>true</c>, items will be reversed.
    /// </remarks>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public bool Reverse { get; set; }

    /// <summary>
    /// The gap between items in increments of <c>4px</c>.
    /// </summary>
    /// <remarks>
    /// <para>Defaults to 3 in <see cref="MudGlobal.StackDefaults.Spacing"/>.</para>
    /// <para>Maximum is 20 (<c>80px</c>).</para>
    /// </remarks>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public int Spacing { get; set; } = MudGlobal.StackDefaults.Spacing;

    /// <summary>
    /// Defines the distribution of child items.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>null</c>.
    /// </remarks>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public Justify? Justify { get; set; }

    /// <summary>
    /// Defines the vertical alignment of child items.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>null</c>.
    /// </remarks>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public AlignItems? AlignItems { get; set; }

    /// <summary>
    /// Defines the stretching behaviour of children along the main axis within a <see cref="MudStack"/> component.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>null</c>.  
    /// </remarks>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public StretchItems? StretchItems { get; set; }

    /// <summary>
    /// Controls how items are wrapped.
    /// </summary>
    /// <remarks>
    /// Defaults to <c>null</c>.
    /// </remarks>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public Wrap? Wrap { get; set; }

    /// <summary>
    /// Sets the flex-direction at the 'extra small' breakpoint.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public FlexDirection? xs { get; set; }

    /// <summary>
    /// Sets the flex-direction at the 'small' breakpoint.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public FlexDirection? sm { get; set; }

    /// <summary>
    /// Sets the flex-direction at the 'medium' breakpoint.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public FlexDirection? md { get; set; }

    /// <summary>
    /// Sets the flex-direction at the 'large' breakpoint.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public FlexDirection? lg { get; set; }

    /// <summary>
    /// Sets the flex-direction at the 'extra large' breakpoint.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public FlexDirection? xl { get; set; }

    /// <summary>
    /// Sets the flex-direction at the 'extra extra large' breakpoint.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public FlexDirection? xxl { get; set; }

    /// <summary>
    /// The content within this component.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.Stack.Behavior)]
    public RenderFragment? ChildContent { get; set; }
}
