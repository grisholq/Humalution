using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private TileView _view;

    [field: SerializeField] public TileEnvironment Enironment { get; private set; }

    public TileOwnerData OwnerData { get; private set; }
    public TileNeighbours Neighbours { get; private set; }
    public TilePopulation Population { get; private set; }

    private void Awake()
    {
        InizializeComponents();
    }

    private void InizializeComponents()
    {
        OwnerData = GetComponent<TileOwnerData>();
        Neighbours = GetComponent<TileNeighbours>();
        Neighbours.Tile = this;
        Population = GetComponent<TilePopulation>();
    }

    public void CaptureTile(float population, IPlayer owner)
    {
        Population.Add(population);
        OwnerData.Owner = owner;      
    }
}