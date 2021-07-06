using UnityEngine;

public class Team : MonoBehaviour, ITeam
{
    [SerializeField] private Tile[] _startingTiles;
    [SerializeField] private Color _color;

    private Land _land;

    [field: SerializeField] public TeamParameters Parameters { get; }

    public ILand Land => _land;

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
        if (_startingTiles != null && _startingTiles.Length != 0)
        {
            _land = new Land(this, _startingTiles);
        }
        else
        {
            _land = new Land(this);
        }
    }
}