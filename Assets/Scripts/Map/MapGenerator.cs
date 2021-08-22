using UnityEngine;

[RequireComponent(typeof(TilesGridFactory))]
public class MapGenerator : MonoBehaviour
{
    [SerializeField] private int _gridWidth;
    [SerializeField] private int _gridHeight;

    private TilesGridFactory _gridFactory;

    private void Awake()
    {
        _gridFactory = GetComponent<TilesGridFactory>();
    }

    private void Start()
    {
        CreateMap();
    }

    private void CreateMap()
    {
        Map map = InstantiateMap();
        map.TilesGrid = _gridFactory.GetTilesGrid(_gridWidth, _gridHeight);
    }

    private Map InstantiateMap()
    {
        return new GameObject("Map").AddComponent<Map>();
    }
}