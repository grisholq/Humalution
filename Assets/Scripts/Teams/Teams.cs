using UnityEngine;
using System.Collections.Generic;

public class Teams : MonoBehaviour
{
    [SerializeField] private Transform _teamsParent;
    private List<Team> _teams;

    private void Awake()
    {
        Team[] teams = _teamsParent.GetComponentsInChildren<Team>();
        _teams = new List<Team>(teams);
    }

    public List<Team> GetTeamsList()
    {
        return _teams;
    }
}