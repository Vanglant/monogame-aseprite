using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace MonoGame.Aseprite;

public static class PointExtensions
{
    /// <summary>
    /// Gets a <see cref="Vector2"/> representation for this object.
    /// </summary>
    /// <returns>A <see cref="Vector2"/> representation for this object.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 ToVector2(this Point point)
    {
        return new Vector2(point.X, point.Y);
    }
}
