public class NullStats : IStats
{
    public IStatsData Stats => null;
    public float Defence => 0;
    public float Attack => 0;
    public float BirthRate => 0;
    public float MigrantsAmount => 0;
    public float PopulationToExpand => 0;
    public float SoldiersPerBattle => 0;
    public float PopulationToAttack => 0;
}