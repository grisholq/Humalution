public static class PopulationBirthHandler
{
    private const float BirthRate = 1;

    public static void HandleBirth(Population population, float multiplier)
    {
        population.Birth(GetBirthCount(population) * multiplier);
    }

    private static float GetBirthCount(Population population)
    {
        return population.Amount * BirthRate;
    }
}