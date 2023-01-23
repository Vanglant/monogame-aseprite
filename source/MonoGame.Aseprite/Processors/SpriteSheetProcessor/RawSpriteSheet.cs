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

using Microsoft.Xna.Framework;

namespace MonoGame.Aseprite.Processors;

/// <summary>
///     Defines the raw values for a <see cref="SpriteSheet"/> used by the <see cref="SpriteSheetProcessor"/>.
/// </summary>
public sealed class RawSpriteSheet
{
    private Rectangle[] _regions;
    internal string Name { get; }
    internal RawTexture Texture { get; }
    internal ReadOnlySpan<Rectangle> Regions => _regions;
    internal Dictionary<string, RawAnimationCycle> Cycles { get; }

    internal RawSpriteSheet(string name, RawTexture texture, Rectangle[] regions, Dictionary<string, RawAnimationCycle> cycles) =>
        (Name, Texture, _regions, Cycles) = (name, texture, regions, cycles);

}
