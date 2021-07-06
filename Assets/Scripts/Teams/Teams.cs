using UnityEngine;
using System.Collections.Generic;

public class Teams : MonoBehaviour
{
    private List<ITeam> _teams;

    private void Awake()
    {
        ITeam[] teams = GetComponentsInChildren<ITeam>();
        _teams = new List<ITeam>(teams);
    }

    public List<ITeam> GetTeams()
    {
        return _teams;
    }
}