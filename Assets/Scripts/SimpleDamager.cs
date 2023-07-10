using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDamager : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private int _damage = 1;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        IDamageble damageble;
        if (collider.TryGetComponent<IDamageble> (out damageble))
        {
            damageble.Damage(-_damage);
        }
    }
}
