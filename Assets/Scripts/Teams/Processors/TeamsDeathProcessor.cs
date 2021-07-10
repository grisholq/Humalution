  using UnityEngine;

public class TeamsDeathProcessor : MonoBehaviour, ITeamProcessor
{
    [SerializeField] private float deathCoefficient;
    [SerializeField] private float illnesPerPopulation;

    public void ProcessTeam(Team team)
    {
        foreach (var tile in team.Land.Tiles)
        {
            CalculateTeamDeath(team);
        }
    }

    private void CalculateTeamDeath(Team team)
    {
        foreach (var tile in team.Land.Tiles)
        {
            CalculateTileDeath(tile, team.Parameters.MedicineEfficience);
        }
    }

    private void CalculateTileDeath(Tile tile, float medicineEfficiency)
    {
        float population = tile.Population.Amount;
        float deeathMultiplier = tile.Enviroment.IllnessRate + illnesPerPopulation * population;
        Mathf.Min(deeathMultiplier, 1);

        tile.Population.Die(tile.Population.Amount * deeathMultiplier);
    }
}