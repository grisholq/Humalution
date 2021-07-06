using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    [SerializeField] private Bounds bounds;

    public void ClampCameraPosition()
    {
        if (!bounds.Contains(transform.position))
        {
            transform.position = bounds.ClosestPoint(transform.position);
        }
    }
}