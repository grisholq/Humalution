using System;
using UnityEngine;

[Serializable]
public class FloatRange
{
    [SerializeField] private float min;
    [SerializeField] private float max;

    public float Min { get => min; }
    public float Max { get => max; }

    public float RandomValue
    {
        get => UnityEngine.Random.Range(min, max);                        
    }

    public bool IsInRange(float value)
    {
        return value <= max && value <= min;
    }

    public float Clamp(float value)
    {
        return Mathf.Clamp(value, min, max);
    }
}