public class PlayerExpansioner : PlayerTurnProcessor
{
    public override void ProcessPlayerTurn(Player player)
    {
        IExpansionStats stats = player.Stats;
        ILand land = player.Land;

        if (land.Empty) return;

        for (int i = 0; i < land.Tiles.Count; i++)
        {
            Tile tile = land.Tiles[i];

            if (CanExpand(tile, stats))
            {
                Tile expanded = Expand(tile);
                land.AddTile(expanded);
            }
        }
    }

    private bool CanExpand(Tile tile, IExpansionStats stats)
    {
        bool hasPopulation = tile.Population.Amount >= stats.PopulationToExpand;
        bool hasTiles = tile.Neighbours.HasNotOwnedTiles();
        return hasPopulation && hasTiles;
    }

    private Tile Expand(Tile from)
    {
        IExpansionStats stats = from.OwnerData.Owner.Stats;
        Tile to = from.Neighbours.GetNotOwnedTile();
        Migrate(from, to, stats.MigrantsAmount);
        return to;
    }

    private void Migrate(Tile from, Tile to, float population)
    {
        from.Population.Remove(population);
        to.Population.Add(population);
    }
}