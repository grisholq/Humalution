using UnityEngine;
using System.Collections.Generic;

public class StatsListUI : MonoBehaviour
{
    [SerializeField] private StatUI _prefab;

    private List<StatUI> _statsUI;

    public void ShowUIStats(IEnumerable<Stat> stats)
    {
        _statsUI = new List<StatUI>();
        foreach (var stat in stats)
        {
            AddStatUI(stat);
        }
    }

    private void AddStatUI(Stat stat)
    {
        StatUI statUI = Instantiate(_prefab, transform);
        statUI.SetStat(stat);
        _statsUI.Add(statUI);
    }

    public void RemoveAllStatsUI()
    {
        foreach (var statUI in _statsUI)
        {
            Destroy(statUI.gameObject);
        }
        _statsUI.Clear();
    }
}