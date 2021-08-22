using UnityEngine;
using System.Collections.Generic;

public static class ListExtentions
{
    public static T RandomElement<T>(this List<T> list)
    {        
        return list[Random.Range(0, list.Count)];
    }
}