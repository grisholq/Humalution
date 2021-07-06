using System;
using UnityEngine;

[Serializable]
public class EnvironmentParameters
{
    [field: SerializeField] public float Fertility { get; set; }
    [field: SerializeField] public float IllnessRate { get; set; }
}