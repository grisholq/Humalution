using UnityEngine;

public class TeamsBirthProcessor : MonoBehaviour, ITeamProcessor
{
    [SerializeField] private float birthCoefficient;

    public void ProcessTeam(Team team)
    {
        foreach (var tile in team.Land.Tiles)
        {
            CalculateTeamBirth(team);   
        }
    }

    private void CalculateTeamBirth(Team team)
    {
        foreach (var tile in team.Land.Tiles)
        {
            CalculateTileBirth(tile, team.Parameters.MedicineEfficience);
        }
    }

    private void CalculateTileBirth(Tile tile, float medicineEfficiency)
    {
        float birthMultiplier = medicineEfficiency * tile.Enviroment.Fertility * birthCoefficient;
        tile.Population.Birth(tile.Population.Amount * birthMultiplier);   
    }
}