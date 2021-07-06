public interface ITeam : IOwner
{
    ILand Land { get; }
    TeamParameters Parameters { get; }
}