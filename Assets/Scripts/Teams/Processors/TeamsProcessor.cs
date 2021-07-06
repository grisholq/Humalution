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
        Debug.Log(_teamProcessors.Count);
    }

    private void Update()
    {
        UpdateTeams();
    }

    private void UpdateTeams()
    {
        foreach (var team in _teams.GetTeams())
        {
            foreach (var processor in _teamProcessors)
            {
                processor.ProcessTeam(team);
            }
        }
    }
}