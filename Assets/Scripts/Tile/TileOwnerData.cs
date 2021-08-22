using UnityEngine;
using UnityEngine.Events;

public class TileOwnerData : MonoBehaviour
{
    [SerializeField] private UnityEvent<IPlayer> OwnerChanged;

    private IPlayer _owner;

    public IPlayer Owner
    {
        get => _owner;

        set
        {
            _owner = value;
            OwnerChanged?.Invoke(value);
        }
    }

    private void Awake()
    {
        _owner = new NullPlayer();
    }

    public void RemoveOwner()
    {
        Owner = new NullPlayer();
    }
}