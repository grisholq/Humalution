public interface IStats : IWarStats, IBirthStats, IExpansionStats
{
    public IStatsData Stats { get; }
}