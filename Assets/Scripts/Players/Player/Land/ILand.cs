using System.Collections.Generic;

public interface ILand
{
    List<Tile> Tiles { get; }
    bool Empty { get; }
    void AddTile(Tile tile);
    void RemoveTile(Tile tile);
}