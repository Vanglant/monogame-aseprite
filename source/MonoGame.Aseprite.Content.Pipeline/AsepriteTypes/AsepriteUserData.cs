/* ----------------------------------------------------------------------------
MIT License

Copyright (c) 2018-2023 Christopher Whitley

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
---------------------------------------------------------------------------- */

using System.Diagnostics.CodeAnalysis;
using Microsoft.Xna.Framework;

namespace MonoGame.Aseprite.Content.Pipeline.AsepriteTypes;

internal sealed class AsepriteUserData
{
    internal string? Text { get; set; }
    internal Color? Color { get; set; }

    [MemberNotNullWhen(true, nameof(Text))]
    internal bool HasText => Text is not null;

    [MemberNotNullWhen(true, nameof(Color))]
    internal bool HasColor => Color is not null;

    internal AsepriteUserData(string? text = default, Color? color = default) =>
        (Text, Color) = (text, color);
}

// /// <summary>
// ///     Represents the custom user data that a user can set for a cel, layer,
// ///     slice, or tag in an Aseprite image.
// /// </summary>
// /// <param name="Text">
// ///     The custom text value that was set for this
// ///     <see cref="AsepriteUserData"/>.
// /// </param>
// /// <param name="Color">
// ///     The custom color value that was set for this
// ///     <see cref="AsepriteUserData"/>.
// /// </param>
// public sealed record AsepriteUserData(string? Text = default, Color? Color = default)
// {
//     /// <summary>
//     ///     <para>
//     ///         Indicates whether this <see cref="AsepriteUserData"/> has
//     ///         a <see cref="AsepriteUserData.Text"/> value.
//     ///     </para>
//     ///     <para>
//     ///         When this returns <see langword="true"/> it guarantees that
//     ///         the <see cref="AsepriteUserData.Text"/> value of this
//     ///         instance  is not <see langword="null"/>.
//     ///     </para>
//     /// </summary>
//     [MemberNotNullWhen(true, nameof(Text))]
//     public bool HasText => Text is not null;

//     /// <summary>
//     ///     <para>
//     ///         Indicates whether this <see cref="AsepriteUserData"/> has
//     ///         a <see cref="AsepriteUserData.Color"/> value.
//     ///     </para>
//     ///     <para>
//     ///         When this returns <see langword="true"/> it guarantees that
//     ///         the <see cref="AsepriteUserData.Color"/> value of this
//     ///         instance  is not <see langword="null"/>.
//     ///     </para>
//     /// </summary>
//     [MemberNotNullWhen(true, nameof(Color))]
//     public bool HasColor => Color is not null;
// }
