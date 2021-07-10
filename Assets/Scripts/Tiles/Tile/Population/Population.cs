using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Population
{
    [SerializeField] private float _amount;
    public float Amount 
    {
        get => _amount; 
        set
        {
            _amount = value;
            PopulationChanged.Invoke(_amount);
        }
    }

    [SerializeField] private UnityEvent<float> PopulationChanged;

    public void Birth(float amount)
    {
        _amount += amount;

        if(float.MaxValue - _amount <= amount)
        {
            _amount = float.MaxValue;
        }

        PopulationChanged.Invoke(_amount);
    }

    public void Die(float amount)
    {
        _amount -= amount;
        _amount = Mathf.Max(0, Amount);
        PopulationChanged.Invoke(_amount);
    }
}