using UnityEngine;

public class NullOwner : IOwner
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
}