using UnityEngine;

public class TilesDeathHandler : MonoBehaviour
{
    [SerializeField] private float illnesSpreadGrowthPerPopulation;

    [field: SerializeField] private float DeathCoefficient;

    private const float lifeTimeInMonth = 12 * 60;

  /*  public void HandleTileDeath(Tile tile)
    {
        float deathAmount = GetDeathAmount(tile) * GetRandomDeathEfficiency() * Time.deltaTime;
        tile.Population.Die(deathAmount);
    }

    private float GetRandomDeathEfficiency()
    {
        return Random.Range(0.5f, 1.5f);
    }

    private float GetDeathAmount(Tile tile)
    {
        float populationAmount = tile.Population.Amount;

        float illnesRate = 
            GetPopulationIllnesRate(populationAmount) 
            + tile.EnvironmentParameters.IllnessRate;

        illnesRate = Mathf.Clamp(illnesRate, 0, 0.999f);

        float deathModifier =
            1 / (lifeTimeInMonth * (1 - illnesRate))
            * DeathCoefficient;

        float deathAmount = populationAmount * deathModifier;

        return deathAmount;
    }

    private float GetPopulationIllnesRate(float population)
    {
        return population * illnesSpreadGrowthPerPopulation;
    }*/
}