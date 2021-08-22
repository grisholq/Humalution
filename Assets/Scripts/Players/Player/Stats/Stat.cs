using System;
using UnityEngine;

[Serializable]
public class Stat : ILevelable
{
    [SerializeField] private StatData _data;

    public StatData Data => _data;
    public float StatValue => _data.Values[_level];
    public bool IsLevelable => _level < _data.Values.Count - 1;
    public int Level => _level;

    private int _level;

    public void LevelUp()
    {
        if(IsLevelable)
        {
            _level++;
        }     
    }

    public void Reset()
    {
        _level = 0;
    }
}