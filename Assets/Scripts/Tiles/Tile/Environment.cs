using System;
using UnityEngine;

[Serializable]
public class Environment
{
    [field: SerializeField] public float Fertility { get; private set; }
    [field: SerializeField] public float IllnessRate { get; private set; }
}