using UnityEngine;

public class TeamPopulator : ITeamProcessor
{
    public void ProcessTeam(Team team)
    {
        ProcessLandPopulation(team.Land, team.Parameters);
    }

    private void ProcessLandPopulation(Land land, TeamParameters teamParameters)
    {
        foreach (var tile in land.Tiles)
        {
            Population.HandleBirth(tile.Population, tile.Fertility * teamParameters.Medicine * Time.deltaTime);
            Population.HandleDeath(tile.Population, tile.IllnesRate * Mathf.Pow(teamParameters.Medicine, -1) * Time.deltaTime);
        }
    }
}