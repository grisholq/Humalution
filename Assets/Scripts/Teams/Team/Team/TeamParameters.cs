using System;
using UnityEngine;

[Serializable]
public class TeamParameters
{
    [field: SerializeField] public float DeathCoefficient;
    [field: SerializeField] public float BirthCoefficient;
    [field: SerializeField] public float ExpansionCoefficient;
}