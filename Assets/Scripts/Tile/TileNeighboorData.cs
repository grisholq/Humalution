using UnityEngine;
using System.Collections.Generic;

public class TileNeighboorData : MonoBehaviour
{
    [SerializeField] private List<TileData> neighboorTiles;

    public List<TileData> NeighboorTiles { get => neighboorTiles; }
}