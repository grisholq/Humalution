using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CameraBounds))]
public class CameraZoomer : MonoBehaviour
{
    [SerializeField] private float speed;
  
    [SerializeField] private UnityEvent cameraZoomed;

    private void OnEnable()
    {
        ZoomInput.Instance.OnZoomInput += ZoomCamera;
    }

    private void OnDisable()
    {
        ZoomInput.Instance.OnZoomInput -= ZoomCamera;
    }

    public void ZoomCamera(float delta)
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.y += delta * speed;
        cameraZoomed.Invoke();
    }
}