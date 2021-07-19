public static class PopulationDeathHandler
{
    private const float DeathRate = 0.1f;
    private const float DeathRatePerPopulation = 0.001f;

    public static void HandleDeath(Population population, float multiplier)
    {
        population.Die(GetDeathAmount(population) * multiplier);
    }

    private static float GetDeathAmount(Population population)
    {
        return population.Amount * DeathRate + population.Amount * DeathRatePerPopulation;
    }
}