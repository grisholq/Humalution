using UnityEngine;
using System.Collections.Generic;

public class TilesGridFactory : MonoBehaviour
{
    [SerializeField] private List<Tile> _tiles;

    private TilesGridPositioner _positioner;
    private TilesGridNeighboursSetter _neighboursSetter;

    private void Awake()
    {
        _positioner = new TilesGridPositioner();
        _neighboursSetter = new TilesGridNeighboursSetter();
    }

    public TilesGrid GetTilesGrid(int width, int height)
    {
        TilesGrid grid = new TilesGrid(GetTilesArray(width, height));
        _positioner.PositionTilesGrid(grid);
        _neighboursSetter.SetNeighbours(grid);
        return grid;
    }

    private Tile[][] GetTilesArray(int width, int height)
    {
        Tile[][] tiles = new Tile[height][];

        for (int i = 0; i < height; i++)
        {
            tiles[i] = GetTilesRow(width);
        }

        return tiles;
    }

    private Tile[] GetTilesRow(int width)
    {
        Tile[] row = new Tile[width];

        for (int i = 0; i < width; i++)
        {
            row[i] = GetTile();
        }

        return row;
    }

    private Tile GetTile()
    {
        return _tiles.RandomElement();
    }
}