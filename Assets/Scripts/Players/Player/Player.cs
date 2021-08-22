using UnityEngine;

[RequireComponent(typeof(PlayerLand), typeof(PlayerStats))]
public class Player : MonoBehaviour, IPlayer
{
    [SerializeField] private Color _color;
    public Color Color => _color;

    public ILand Land { get; private set; }
    public IStats Stats { get; private set; }

    private void Awake()
    {
        Land = GetComponent<ILand>();
        Stats = GetComponent<IStats>();
    }

    public void OwnTile(Tile tile)
    {
        tile.OwnerData.Owner = this;
    }

    public void DisownTile(Tile tile)
    {
        tile.OwnerData.Owner = new NullPlayer();
    }
}