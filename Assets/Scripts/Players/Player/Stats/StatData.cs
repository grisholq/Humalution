using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "StatData", menuName = "MyAssets/StatData")]
public class StatData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Texture _image;
    [SerializeField] private List<float> _values;

    public string Name => _name;
    public Texture Image => _image;
    public List<float> Values => _values;
}