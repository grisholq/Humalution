using UnityEngine;
using System.Collections.Generic;

public class Teams : MonoBehaviour
{
    private List<Team> _teams;

    private void Awake()
    {
        _teams = new List<Team>(transform.GetComponentsInChildren<Team>());
    }

    public List<Team> GetTeams()
    {
        return _teams;
    }
}