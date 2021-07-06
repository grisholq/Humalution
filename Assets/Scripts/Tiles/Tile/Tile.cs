using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class Tile : MonoBehaviour, IPopulated, IOwned
{
    [SerializeField] private float _startingPopulation;

    [field: SerializeField] public Population Population { get; set; }
    [field: SerializeField] public EnvironmentParameters EnvironmentParameters { get; set; }
    [field: SerializeField] public List<Tile> Neighbors { get; set; }

    [SerializeField] private UnityEvent<IOwner> OwnerChanged;

    private IOwner _owner;

    public IOwner Owner
    {
        get
        {
            return _owner;
        }

        set
        {
            _owner = value;
            OwnerChanged.Invoke(_owner);
        }
    }

    private void Start()
    {
        Owner = new NullOwner();
        Population.Amount = _startingPopulation;
    }

    private void CallOwnerChanged(IOwner owner)
    {
        if (OwnerChanged != null) OwnerChanged.Invoke(owner);
    }  
}