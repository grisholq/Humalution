using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour, IStats
{
    [SerializeField] private PlayerStatsData _statsStorage;

    public IStatsData Stats => _statsStorage;

    public float Defence => _statsStorage.Defence.StatValue;
    public float Attack => _statsStorage.Attack.StatValue;
    public float BirthRate => 2;
    public float MigrantsAmount => 5;
    public float PopulationToExpand => 30;
    public float SoldiersPerBattle => 3;
    public float PopulationToAttack => 35;

    private void Awake()
    {
        foreach (var stat in _statsStorage.Stats)
        {
            stat.Reset();
        }
    }
}