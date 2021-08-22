using UnityEngine;

public interface IPlayer
{
    Color Color { get; }
    IStats Stats { get; }
    void OwnTile(Tile tile);
    void DisownTile(Tile tile);
}