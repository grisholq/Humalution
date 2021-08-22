using System;
using UnityEngine;

[Serializable]
public class TileEnvironment
{
    [field: SerializeField] public float Fertility { get; private set; }
    [field: SerializeField] public float Defence { get; private set; }
}