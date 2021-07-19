using UnityEngine;

public class OwnerView : MonoBehaviour
{
    [SerializeField] private MeshRenderer _ownerMarker;

    public void SetOwner(IOwner owner)
    {
        _ownerMarker.material.color = owner.Color;
    }
}