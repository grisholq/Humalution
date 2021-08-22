using UnityEngine;

public class TilesGridPositioner
{
    public void PositionTilesGrid(TilesGrid grid)
    {
        for (int r = 0; r < grid.RowsCount; r++)
        {
            for (int c = 0; c < grid.CollumnsCount; c++)
            {
                Tile tile = grid.GetTile(r, c);
                tile.transform.position = new Vector3(c, 0, r);
            }
        }
    }
}