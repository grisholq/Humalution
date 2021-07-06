using UnityEngine;

public class TeamsPopulator : MonoBehaviour, ITeamProcessor
{
    [SerializeField] private float illnesSpreadPerHuman;

    private const float birthTimeInMonth = 9;
    private const float lifeTimeInMonth = 720;

    public void ProcessTeam(ITeam team)
    {
        foreach (var tile in team.Land.Tiles)
        {
            ProcessTilePopulationChange(tile, team.Parameters);
        }
    }

    private void ProcessTilePopulationChange(Tile tile, TeamParameters parameters)
    {
        HandleTileBirth(tile, parameters);
        HandleTileDeath(tile, parameters);
    }

    private void HandleTileBirth(Tile tile, TeamParameters parameters)
    {
        float birthMultiplier = 
            parameters.BirthCoefficient 
            * tile.EnvironmentParameters.Fertility;

        float birthAmount = GetBirthAmount(tile.Population.Amount, parameters.BirthCoefficient);

        tile.Population.Birth(birthAmount * Time.deltaTime);
    }

    private void HandleTileDeath(Tile tile, TeamParameters parameters)
    {
        float illnesRate = 
            parameters.DeathCoefficient 
            * tile.EnvironmentParameters.IllnessRate;

        float deathAmount = GetDeathAmount(tile.Population.Amount, deathMultiplier);

        tile.Population.Die(deathAmount * Time.deltaTime);
    }

    private float GetBirthAmount(float population, float multiplier)
    {
        float birthAmount = 
            population
            * (1 / birthTimeInMonth) 
            * multiplier;

        return birthAmount;
    }
    
    private float GetDeathAmount(float population, float multiplier)
    {
        float deathAmount = 
            population * 1 / (lifeTimeInMonth * (1 - il))
             
    }
}