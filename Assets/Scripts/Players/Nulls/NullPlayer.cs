using UnityEngine;

public class NullPlayer : IPlayer
{
    public Color Color 
    {
        get
        {
            Color color = Color.white;
            color.a = 0;
            return color;
        }
    }

    public IStats Stats => new NullStats();

    public void DisownTile(Tile tile)
    {

    }

    public void OwnTile(Tile tile)
    {

    }
}