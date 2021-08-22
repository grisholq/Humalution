using System;
using UnityEngine;

public class Population
{
    private float _amount;
    
    public float Amount 
    {
        get => _amount;
        set
        {
            _amount = Mathf.Clamp(value, 0, _maxPopulation);
            if(PopulationChanged != null) PopulationChanged(_amount);
        }
    }

    public event Action<float> PopulationChanged;

    private const float _maxPopulation = 5000000;

    public Population()
    {
        Amount = 0;
    }
    
    public Population(float startingAmount)
    {
        Amount = startingAmount;
    }

    public void Birth(float amount)
    {
        Amount += amount;
    }

    public void Die(float amount)
    {
        Amount -= amount;
    }
}