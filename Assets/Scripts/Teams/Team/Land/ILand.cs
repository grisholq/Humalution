using System;
using System.Collections.Generic;

public interface ILand : IOwned
{
    IEnumerable<Tile> Tiles { get; }

    void AddTile(Tile tile);
    void RemoveTile(Tile tile);
}