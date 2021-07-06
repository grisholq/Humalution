using System.Collections.Generic;

public class Land : ILand
{
    private IOwner _owner;
    private LinkedList<Tile> _tiles;

    public IOwner Owner { get; set; }
    public IEnumerable<Tile> Tiles => _tiles;

    public Land(IOwner owner)
    {
        _owner = owner;
        _tiles = new LinkedList<Tile>();
    }

    public Land(IOwner owner, Tile[] startingTiles)
    {
        _owner = owner;
        _tiles = new LinkedList<Tile>();        

        for (int i = 0; i < startingTiles.Length; i++)
        {
            _tiles.AddLast(startingTiles[i]);
            startingTiles[i].Owner = _owner;
        }
    }

    public void AddTile(Tile tile)
    {
        tile.Owner = _owner;    
        if (!_tiles.Contains(tile))
        {
            _tiles.AddLast(tile);
        }
    }

    public void RemoveTile(Tile tile)
    {
        tile.Owner = new NullOwner();
        if(_tiles.Contains(tile))
        {
            _tiles.Remove(tile);
        }       
    }
}