using System.Linq;
using System.Collections.Generic;

public class TilesGrid
{
    private Tile[][] _grid;

    public int RowsCount { get; private set; }
    public int CollumnsCount { get; private set; }

    public IEnumerable<Tile> Tiles
    {
        get
        {
            IEnumerable<Tile> tiles = new Tile[] { };

            for (int i = 0; i < _grid.Length; i++)
            {
                tiles = tiles.Concat(_grid[i]);
            }
            return tiles;
        }
    }

    public TilesGrid(Tile[][] grid)
    {
        _grid = grid;
        RowsCount = _grid.Length;
        CollumnsCount = _grid[0].Length;
    }    

    public Tile GetTile(int row, int collumn)
    {
        return _grid[row][collumn];
    }

    public bool ContainsTile(int row, int collumn)
    {
        return ContainsRow(row) && ContainsCollumn(collumn);
    }

    private bool ContainsRow(int row) => row >= 0 && row < RowsCount;
    private bool ContainsCollumn(int collumn) => collumn >= 0 && collumn < CollumnsCount;
}