using UnityEngine;
using TMPro;

public class TilePopulator : MonoBehaviour
{
    [SerializeField] private float population;
    [SerializeField] private float terrainBirthrRate;
    [SerializeField] private TextMeshPro populationText;

    public float Population { get => population; set => population = value; }

    private const float birthCoefficient = 0.03f;
    private const float maxProsperity = 10;


    private void Update()
    {
        UpdatePopulation();
    }

    private void UpdatePopulation()
    {
        float prosperity = (Random.Range(0, maxProsperity) / maxProsperity);
        float birthRate = prosperity * birthCoefficient * terrainBirthrRate;
        Population += Population * birthRate * Time.deltaTime;
        populationText.text = ((int)Population).ToString();
    }
}