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

using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using MonoGame.Aseprite.Content.Pipeline.ContentTypes;
using MonoGame.Aseprite.RawTypes;

namespace MonoGame.Aseprite.Content.Pipeline.Writers;

[ContentTypeWriter]
internal sealed class SpriteSheetContentTypeWriter : ContentTypeWriter<SpriteSheetContent>
{
    protected override void Write(ContentWriter writer, SpriteSheetContent content)
    {
        RawSpriteSheet rawSpriteSheet = content.RawSpriteSheet;
        writer.Write(rawSpriteSheet.Name);
        writer.Write(rawSpriteSheet.RawTextureAtlas.Name);
        writer.WriteObject(content.Texture2DContent);
        writer.Write(rawSpriteSheet.RawTextureAtlas.RawTextureRegions);
        writer.Write(rawSpriteSheet.RawAnimationTags);
    }

    public override string GetRuntimeType(TargetPlatform targetPlatform) =>
        "MonoGame.Aseprite.Sprites.SpriteSheet, MonoGame.Aseprite";

    public override string GetRuntimeReader(TargetPlatform targetPlatform) =>
        "MonoGame.Aseprite.Content.Pipeline.Readers.SpriteSheetContentTypeReader, MonoGame.Aseprite";
}
