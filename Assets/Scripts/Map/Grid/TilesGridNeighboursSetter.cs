using UnityEngine;
using System.Collections.Generic;

public class TilesGridNeighboursSetter
{
    public void SetNeighbours(TilesGrid grid)
    {
        for (int r = 0; r < grid.RowsCount; r++)
        {
            for (int c = 0; c < grid.CollumnsCount; c++)
            {
                SetTileNeighbours(grid, r, c);
            }
        }
    }

    private void SetTileNeighbours(TilesGrid grid, int row, int collumn)
    {
        List<Tile> neighbours = GetTileNeighbours(grid, row, collumn);
        Tile tile = grid.GetTile(row, collumn);
        tile.Neighbours.List = neighbours;
    }

    private List<Tile> GetTileNeighbours(TilesGrid grid, int row, int collumn)
    {
        List<Tile> neighbours = new List<Tile>();

        for (int rowOffset = -1; rowOffset <= 1; rowOffset++)
        {
            for (int collumnOffset = -1; collumnOffset <= 1; collumnOffset++)
            {
                if (rowOffset == 0 && collumnOffset == 0) continue;

                int neighbourRow = row + rowOffset;
                int neighbourCollumn = collumn + collumnOffset;

                if (grid.ContainsTile(neighbourRow, neighbourCollumn))
                {
                    neighbours.Add(grid.GetTile(neighbourRow, neighbourCollumn));
                }
            }
        }
        return neighbours;
    }
}