using System;
using System.Collections.Generic;

[Serializable]
public class PlayerStatsData : IStatsData
{
    public IEnumerable<Stat> Stats
    {
        get
        {
            List<Stat> stats = new List<Stat>();
            stats.Add(Defence);
            stats.Add(Attack);
            return stats;
        }
    }

    public Stat Defence;
    public Stat Attack;
}