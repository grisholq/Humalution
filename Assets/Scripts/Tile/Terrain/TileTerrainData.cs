using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "TerrainData", menuName = "MyAssets/TerrainData")]
public class TileTerrainData : ScriptableObject
{
    [SerializeField] private Transform terrainBase;
    [SerializeField] private Transform terrainContent;

    public Transform TileBase { get => terrainBase; }
    public Transform TileContent { get => terrainContent; }
}