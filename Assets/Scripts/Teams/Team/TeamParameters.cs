using System;
using UnityEngine;

[Serializable]
public class TeamParameters
{
    [field: SerializeField] public float Medicine { get; set; }
    [field: SerializeField] public float Expansion { get; set; }
    [field: SerializeField] public float War { get; set; }
}