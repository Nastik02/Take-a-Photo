using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressibleBar : MonoBehaviour
{
    [SerializeField] private Progressible _progressible;
    [SerializeField] private Image[] _markers;
    [SerializeField] private Sprite _full;
    [SerializeField] private Sprite _empty;


    private void Start()
    {
        ShowValue(_progressible.Value);
        _progressible.OnChange.AddListener(ShowValue);
    }
    private void OnDestroy()
    {
        _progressible.OnChange.RemoveListener(ShowValue);
    }
    private void ShowValue(int energy)
    {
        for (int i = 0; i < _markers.Length; i++)
        {
            _markers[i].sprite = i < energy ? _full : _empty;
        }
    }
}
