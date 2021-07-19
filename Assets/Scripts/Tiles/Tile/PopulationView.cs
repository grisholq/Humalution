using TMPro;
using UnityEngine;

public class PopulationView : MonoBehaviour
{
    [SerializeField] private TextMeshPro _population;
    
    public void SetPopulation(float population)
    {
        _population.text = ((int)population).ToString();
    }
}