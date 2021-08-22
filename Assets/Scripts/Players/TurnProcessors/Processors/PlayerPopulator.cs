public class PlayerPopulator : PlayerTurnProcessor
{
    public override void ProcessPlayerTurn(Player player)
    {
        IBirthStats stats = player.Stats;
        ILand land = player.Land;

        if (land.Empty) return;

        foreach (var tile in land.Tiles)
        {
            tile.Population.Add(stats.BirthRate * tile.Enironment.Fertility);
        }
    }
}