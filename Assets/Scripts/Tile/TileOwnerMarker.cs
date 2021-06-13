using UnityEngine;

public class TileOwnerMarker : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetColor(Color color)
    {
        meshRenderer.material.color = color;
    }
}