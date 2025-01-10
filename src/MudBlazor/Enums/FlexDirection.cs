using System.ComponentModel;

namespace MudBlazor;

/// <summary>
/// The flex direction applied to items in a <see cref="MudStack"/>.
/// </summary>
public enum FlexDirection
{
    /// <summary>
    /// The flex container's main-axis is defined to be the same as the text direction. The main-start and main-end points are the same as the content direction.
    /// </summary>
    [Description("row")]
    Row,

    /// <summary>
    /// Behaves the same as row but the main-start and main-end points are opposite to the content direction.
    /// </summary>
    [Description("row-reverse")]
    RowReverse,

    /// <summary>
    /// The flex container's main-axis is the same as the block-axis. The main-start and main-end points are the same as the before and after points of the writing-mode.
    /// </summary>
    [Description("column")]
    Column,

    /// <summary>
    /// Behaves the same as column but the main-start and main-end are opposite to the content direction.
    /// </summary>
    [Description("column-reverse")]
    ColumnReverse
}
