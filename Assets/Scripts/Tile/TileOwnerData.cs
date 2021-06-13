using UnityEngine;

public class TileOwnerData : MonoBehaviour
{
    [SerializeField] private PlayerData owner;
    [SerializeField] private TileOwnerMarker ownerMarker;

    private void Start()
    {
       
    }

    private void Update()
    {
        ownerMarker.SetColor(owner.Color);    
    }

    public PlayerData Owner
    {
        get
        {
            return owner;
        }

        set
        {
            owner = value;
            ownerMarker.SetColor(owner.Color);
        }
    }
}