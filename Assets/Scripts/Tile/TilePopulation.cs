using UnityEngine;
using UnityEngine.Events;

public class TilePopulation : MonoBehaviour
{
    [SerializeField] private float _maxPopulation;
    [SerializeField] private float _startingPopulation;

    [SerializeField] private UnityEvent<float> PopulationChanged;
    [SerializeField] private UnityEvent NoPopulationLeft;

    private float _amount;

    public float Amount
    {
        get => _amount;
        set
        {
            _amount = Mathf.Clamp(value, 0, _maxPopulation);
            PopulationChanged?.Invoke(_amount);
        }
    }

    public bool IsDead => Amount > 0;

    private void Awake()
    {
        Amount = _startingPopulation;
    }

    public void SetAmount(float amount)
    {
        Amount = amount;
    }

    public void Add(float amount)
    {
        Amount += amount;
    }

    public void Remove(float amount)
    {
        Amount -= amount;
        if (Amount <= 0) NoPopulationLeft?.Invoke();
    }
}