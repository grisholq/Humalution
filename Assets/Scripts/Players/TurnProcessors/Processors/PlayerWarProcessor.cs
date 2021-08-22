public class PlayerWarProcessor : PlayerTurnProcessor
{
    public override void ProcessPlayerTurn(Player player)
    {
        ILand land = player.Land;
        IWarStats stats = player.Stats;

        if (land.Empty) return;

        for (int i = 0; i < land.Tiles.Count; i++)
        {
            Tile attacker = land.Tiles[i];
            if(CanWar(attacker, stats))
            {
                Tile defender = attacker.Neighbours.GetEnemyTile();
                Battle(attacker, defender);
            }
        }
    }

    private bool CanWar(Tile tile, IWarStats stats)
    {
        bool hasPopulation = tile.Population.Amount >= stats.PopulationToAttack;
        bool hasTiles = tile.Neighbours.HasEnemyTiles();
        return hasPopulation && hasTiles;
    }

    private void Battle(Tile attacker, Tile defender)
    {
        TilesBattle battle = new TilesBattle(attacker, defender);
        battle.Battle();
    }
}