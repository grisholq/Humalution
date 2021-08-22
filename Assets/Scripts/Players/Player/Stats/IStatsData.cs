using System.Collections.Generic;

public interface IStatsData
{
    public IEnumerable<Stat> Stats { get; }
}