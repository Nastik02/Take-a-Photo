using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodicDamager : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private int _damage = 1;
    [SerializeField] private float _period = 1f;
    private Dictionary<IDamageble, float> _visitors = new Dictionary<IDamageble, float>();
    private void OnTriggerEnter2D(Collider2D collider)
    {
        IDamageble damageble;
        if (collider.TryGetComponent<IDamageble> (out damageble))
        {
            _visitors.TryAdd(damageble, _period);
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        IDamageble damageble;
        if (collider.TryGetComponent<IDamageble>(out damageble))
        {
            _visitors.Remove(damageble);
        }
    }
    private void FixedUpdate()
    {
        var keys = new List<IDamageble>(_visitors.Keys);
        foreach (var visitor in keys)
        {
            _visitors[visitor] += Time.fixedDeltaTime;
            if(_visitors[visitor] >= _period)
            {
                visitor.Damage(-_damage);
                _visitors[visitor] -= _period;
            }
        }
        
    }
}
