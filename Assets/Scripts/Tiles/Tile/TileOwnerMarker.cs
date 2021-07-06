using UnityEngine;

public class TileOwnerMarker : MonoBehaviour
{
    private MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    public void SetOwnerColor(IOwner owner)
    {
        _renderer.material.color = owner.Color;
    }
}