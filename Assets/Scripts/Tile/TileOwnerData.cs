using UnityEngine;

[RequireComponent(typeof(TileData))]
public class TileOwnerData : MonoBehaviour
{
    [SerializeField] private PlayerData owner;
    [SerializeField] private MeshRenderer ownerMarker;

    public PlayerData Owner
    {
        get
        {
            return owner;
        }

        set
        {
            owner = value;
            ownerMarker.material.color
        }
    }
}