using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CameraBounds))]
public class CameraMover : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private UnityEvent cameraMoved;

    private void OnEnable()
    {
        MoveInput.Instance.OnMoveInput += MoveCamera;
    }

    private void OnDisable()
    {
        MoveInput.Instance.OnMoveInput -= MoveCamera;
    }

    public void MoveCamera(Vector2 direction)
    {
        transform.position += -1 * GetMoveDelta(direction);
        cameraMoved.Invoke();
    }

    private Vector3 GetMoveDelta(Vector2 direction)
    {
        return new Vector3(direction.x, 0, direction.y).normalized * speed;
    }
}