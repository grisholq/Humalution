using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private Color color;
    [SerializeField] private int playerId;

    public Color Color { get => color; }
    public int PlayerId { get => playerId; }
}