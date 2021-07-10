using TMPro;
using UnityEngine;

public class TileView : MonoBehaviour
{
    [SerializeField] private TextMeshPro population;
    [SerializeField] private MeshRenderer ownerMarker;

    public void SetOwnerColor(IOwner owner)
    {
        ownerMarker.material.color = owner.Color;
    }

    public void SetPopulationAmount(float amount)
    {
        population.text = ((int)amount).ToString();
    }
}