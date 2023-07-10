using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Progressible: MonoBehaviour
{
    protected int _value = 5;
    [SerializeField] protected int _maxValue = 5;

    public int Value { 
        get => _value; 
    }
    public UnityEvent<int> OnChange;
}
