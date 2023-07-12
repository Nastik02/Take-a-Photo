using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

[DisallowMultipleComponent]
public class Health : Progressible, IDamageble
{
    public UnityEvent OnDie;

    public bool IsAlive
    {
        get
        {
            return Value > 0;
        }
    }

    

    public void Damage(int damage)
    {
        if(damage >= 0)
        {
            Debug.LogWarning("damage must be less than zero");
        }
        ChangeHealth(damage);
    }
    private void ChangeHealth(int delta)
    {
        if (IsAlive)
        {
            Value = Mathf.Clamp(Value + delta, 0, _maxValue);
            if (Value == 0) Death();
        }
    }
    private void Death()
    {
        OnDie?.Invoke();
    }
}
