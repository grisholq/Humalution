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
    }

    private void Start()
    {
        _teamProcessors = new List<ITeamProcessor>();
        _teamProcessors.Add(new TeamPopulator());
        _teamProcessors.Add(new TeamExpansioner());
        _teamProcessors.Add(new TeamWarProcessor());
    }

    private void Update()
    {
        ProcessTeams();
    }

    private void ProcessTeams()
    {
        List<Team> teams = _teams.GetTeams();

        foreach (var team in teams)
        {
            ProcessTeam(team);
        }
    }

    private void ProcessTeam(Team team)
    {
        foreach (var processor in _teamProcessors)
        {
            processor.ProcessTeam(team);
        }
    }
}