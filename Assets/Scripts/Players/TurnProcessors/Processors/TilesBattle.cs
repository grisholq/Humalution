public class TilesBattle
{
    private Tile _attacker;
    private Tile _defender;

    private IWarStats _attackerStats;
    private IWarStats _defenderStats;

    public TilesBattle(Tile attacker, Tile defender)
    {
        _attacker = attacker;
        _defender = defender;

        _attackerStats = attacker.OwnerData.Owner.Stats;
        _defenderStats = attacker.OwnerData.Owner.Stats;
    }

    public void Battle()
    {
        HandleAttacker();
        HandleDefender();
    }

    private void HandleAttacker()
    {
        float kills = GetAttackerKills();
        _defender.Population.Remove(kills);
    }

    private float GetAttackerKills()
    {
        return _attackerStats.SoldiersPerBattle * _attackerStats.Attack;
    }

    private void HandleDefender()
    {
        float kills = GetDefenderKills();
        _attacker.Population.Remove(kills);
    }

    private float GetDefenderKills()
    {
        return _defenderStats.SoldiersPerBattle * _defenderStats.Defence;
    }
}