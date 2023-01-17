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

namespace MonoGame.Aseprite.AsepriteTypes;

/// <summary>
///     Defines a named slice region with frame keys.
/// </summary>
public sealed class AsepriteSlice
{
    private AsepriteSliceKey[] _keys;

    /// <summary>
    ///     Gets a <see cref="ReadOnlySpan{T}"/> of the <see cref="AsepriteSliceKey"/> elements in this
    ///     <see cref="AsepriteSlice"/>.
    /// </summary>
    public ReadOnlySpan<AsepriteSliceKey> Keys => _keys;

    /// <summary>
    ///     Gets a value that indicates if this <see cref="AsepriteSlice"/> and its keys represent a nine-patch region.
    /// </summary>
    public bool IsNinePatch { get; }

    /// <summary>
    ///     Gets a value that indicates if this <see cref="AsepriteSlice"/> and its keys have pivot values.
    /// </summary>
    public bool HasPivot { get; }

    /// <summary>
    ///     Gets the name of this <see cref="AsepriteSlice"/>.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Gets the custom <see cref="AsepriteUserData"/> that was set for this <see cref="AsepriteSlice"/>> in
    ///     Aseprite.
    /// </summary>
    public AsepriteUserData UserData { get; } = new();

    internal AsepriteSlice(string name, bool isNine, bool hasPivot, AsepriteSliceKey[] keys) =>
        (Name, IsNinePatch, HasPivot, _keys) = (name, isNine, hasPivot, keys);
}
