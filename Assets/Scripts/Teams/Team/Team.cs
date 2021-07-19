using UnityEngine;

public class Team : MonoBehaviour, IOwner
{
    [SerializeField] private Tile[] _tiles;
    [SerializeField] private Color _color;
    [field: SerializeField] public TeamParameters Parameters { get; private set; }

    public Land Land { get; private set; } 
   
    public Color Color
    { 
        get
        {
            return _color;
        }
    }
    
    private void Start()
    {
        InizializeLand();
    }

    private void InizializeLand()
    {
        if (_tiles != null && _tiles.Length != 0)
        {
            Land = new Land(this, _tiles);
        }
        else
        {
            Land = new Land(this);
        }
    }
}