using TMPro;
using UnityEngine;

public class TileView : MonoBehaviour
{
    [SerializeField] private TextMeshPro _populationAmountText;
    [SerializeField] private MeshRenderer _ownerMarker;

    public void ShowPopulationCount(float amount)
    {
        if (amount == 0) _populationAmountText.text = "";
        _populationAmountText.text = ((int)amount).ToString();
    }

    public void ShowOwnerColor(IPlayer owner)
    {
        _ownerMarker.material.color = owner.Color;
    }
}