using UnityEngine;

public class Map : MonoBehaviour
{
    private TilesGrid _grid;

    public TilesGrid TilesGrid 
    {
        get => _grid;

        set
        {
            _grid = value;

            foreach (var tile in _grid.Tiles)
            {
                tile.transform.SetParent(transform);
            }
        }
    }
}