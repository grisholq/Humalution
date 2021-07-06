using System;
using UnityEngine;

[Serializable]
public class ObservableValue<T>
{
    [SerializeField] private T _value = default(T);

    public event Action<T> OnValueChange;

    public T Value 
    {
        get
        {
            return _value;
        }

        set
        {
            _value = value;
            OnValueChange(value);
        }
    }
}
