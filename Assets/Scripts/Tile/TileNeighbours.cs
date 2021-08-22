using UnityEngine;
using System.Collections.Generic;

public class TileNeighbours : MonoBehaviour
{
    [SerializeField] private List<Tile> _neighbours;

    public Tile Tile { private get; set; }

    public List<Tile> List
    {
        get => _neighbours;

        set
        {
            _neighbours = value;
        }
    }

    public bool Empty => List == null && List.Count == 0;

    public bool HasNotOwnedTiles()
    {
        Tile notOwned = List.Find((i) => i.OwnerData.Owner is NullPlayer);
        return notOwned != null;
    }

    public Tile GetNotOwnedTile()
    {
        return List.Find((i) => i.OwnerData.Owner is NullPlayer);
    }
    
    public bool HasEnemyTiles()
    {
        Tile enemy = List.Find((i) => i.OwnerData.Owner != Tile.OwnerData.Owner);
        return enemy != null;
    }

    public Tile GetEnemyTile()
    {
        return List.Find((i) => i.OwnerData.Owner != Tile.OwnerData.Owner);
    }
}