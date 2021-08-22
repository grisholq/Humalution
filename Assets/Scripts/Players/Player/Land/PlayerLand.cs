using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class PlayerLand : MonoBehaviour, ILand
{
    [SerializeField] private Tile[] _startingTiles;
    [SerializeField] private float _startingPopulation;

    [SerializeField] private UnityEvent<Tile> TileAdded;
    [SerializeField] private UnityEvent<Tile> TileRemoved;

    public List<Tile> Tiles => _tiles;
    public bool Empty => _tiles.Count == 0;
   
    private List<Tile> _tiles;

    private void Start()
    {
        InizializeTiles();
    }

    private void InizializeTiles()
    {
        _tiles = new List<Tile>();

        if (HasStartingTiles() == false) return;

        foreach (var tile in _startingTiles)
        {
            AddTile(tile);
            tile.Population.SetAmount(_startingPopulation);
        }
    }

    private bool HasStartingTiles()
    {
        return _startingTiles != null && _startingTiles.Length != 0;
    }

    public void AddTile(Tile tile)
    {
        if(_tiles.Contains(tile) == false)
        {
            _tiles.Add(tile);
            TileAdded?.Invoke(tile);
        }       
    }

    public void RemoveTile(Tile tile)
    {
        if(_tiles.Contains(tile))
        {
            _tiles.Remove(tile);
            TileRemoved?.Invoke(tile);
        }
    }
}