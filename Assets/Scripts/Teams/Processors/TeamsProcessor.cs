using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Teams))]
public class TeamsProcessor : MonoBehaviour
{
    private Teams _teams;

    private List<ITeamProcessor> _teamProcessors;

    private void Awake()
    {
        _teams = GetComponent<Teams>();
        _teamProcessors = new List<ITeamProcessor>(GetComponents<ITeamProcessor>());
    }

    private void Update()
    {
        ProcessTeams();
    }

    private void ProcessTeams()
    {
        List<Team> teams = _teams.GetTeamsList();

        foreach (var team in teams)
        {
            foreach (var processor in _teamProcessors)
            {
                processor.ProcessTeam(team);
            }
        }
    }
}