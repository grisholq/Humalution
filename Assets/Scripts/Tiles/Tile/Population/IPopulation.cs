public interface IPopulation
{
    float Amount { get; }
    void Birth(float amount);
    void Die(float amount);
}