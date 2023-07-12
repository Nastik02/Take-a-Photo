using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Progressible: MonoBehaviour
{
    private int _value = 5;
    [SerializeField] protected int _maxValue = 5;

    public int Value { 
        get => _value;
        protected set { _value = value; OnChange?.Invoke(_value); }
    }
    public UnityEvent<int> OnChange;
}
