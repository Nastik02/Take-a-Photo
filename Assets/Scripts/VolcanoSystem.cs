using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanoSystem : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private GameObject _damageZone;
    [SerializeField] private float _cooldownTime = 15f;
    [SerializeField] private float _damageTime = 10f;
    private bool _isPrepareForHit;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        StartCoroutine("VolcanoCycle");
    }

    private void Update()
    {
        
    }

    private IEnumerator VolcanoCycle()
    {
        while (true)
        {
            _isPrepareForHit = true;
            _animator.SetBool("isPrepareForHit", _isPrepareForHit);

            yield return new WaitForSeconds(_cooldownTime);

            _animator.SetBool("isPrepareForHit", !_isPrepareForHit);
            _damageZone.SetActive(!_damageZone.activeSelf);

            yield return new WaitForSeconds(_damageTime);

            _damageZone.SetActive(!_damageZone.activeSelf);

            yield return new WaitForSeconds(_cooldownTime);
        }
    }

}
