using UnityEngine;
using System.Collections.Generic;

public class Tile : MonoBehaviour, IPopulated, IOwned
{
    private OwnerView _ownerView;
    private PopulationView _populationView;

    [SerializeField] private float _startingPopulation;

    [field: SerializeField] public float Fertility { get; private set; }
    [field: SerializeField] public float IllnesRate { get; private set; }
    [field: SerializeField] public List<Tile> Neighbors { get; private set; }

    public Population Population { get; private set; }

    private IOwner _owner;

    public IOwner Owner
    {
        get => _owner;
        set
        {
            _owner = value;
            _ownerView.SetOwner(value);
        }
    }

    private void Awake()
    {
        _ownerView = GetComponent

        Population = new Population(_startingPopulation);
        Population.PopulationChanged += _populationView.SetPopulation;
        Owner = new NullOwner();
    }  
}