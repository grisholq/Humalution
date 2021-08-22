using UnityEngine;

public static class CustomRandom
{
    public static bool Chance(float chance)
    {
        return Random.Range(0, 1f) <= chance;
    }
}