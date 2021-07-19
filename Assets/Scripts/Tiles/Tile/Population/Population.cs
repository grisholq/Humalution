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

    private const float BirthRate = 0.06f;

    private const float DeathRatePerPopulation = 0.003f;

    public static void HandleBirth(Population population, float multiplier)
    {
        float birthAmount = population.Amount * BirthRate;
        population.Birth(birthAmount * multiplier);
    }

    public static void HandleDeath(Population population, float multiplier)
    {
        float deathAmount = population.Amount * DeathRatePerPopulation;
        population.Die(deathAmount * multiplier);
    } 
}