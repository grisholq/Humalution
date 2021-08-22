public interface ILevelable
{
    bool IsLevelable { get; }
    int Level { get; }
    void LevelUp();
    void Reset();
}