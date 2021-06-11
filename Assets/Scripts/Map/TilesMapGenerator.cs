using UnityEngine;
using System.Collections.Generic;

public class TilesMapGenerator : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;

    [SerializeField] private List<TileTerrainData>  tileTerrains;

    private void Awake()
    {
        GenerateMap();
    }

    private Transform GenerateMap()
    {
        Transform map = new GameObject("TilesMap").transform;

        Vector3 start = new Vector3(-width / 2, 0, -height / 2) ;

        for (int i = 0; i < width; i++)
        {
            for (int i1 = 0; i1 < height; i1++)
            {
                Transform tile = CreateTile(tileTerrains.Random());
                tile.position = start + new Vector3(i, 0, i1);
            }
        }

        return map;
    }

    private Transform CreateTile(TileTerrainData terrainData)
    {
        Transform tile = new GameObject("Tile").transform;

        Transform tileBase = Instantiate(terrainData.TileBase, tile);
        Transform tileContent = Instantiate(terrainData.TileContent, tile);

        return tile;
    }
}