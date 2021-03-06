/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
    ///     Sets the direction corresponding to positive angles in legacy polar charts.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value=@"clockwise")]
        Clockwise,
        [EnumMember(Value=@"counterclockwise")]
        Counterclockwise
    }
}