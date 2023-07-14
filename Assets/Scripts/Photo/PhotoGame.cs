using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PhotoGame : MonoBehaviour
{
    [SerializeField] Image _background;
    [SerializeField] Image _normalPhoto;
    [SerializeField] Image _blurryPhoto;
    [SerializeField] Image[] _verticalLine;
    [SerializeField] Image[] _horizontallLine;
    [SerializeField] private int _accuracy = 1;
    [SerializeField] private float _speed = 3f;
    private Image[] _line;
    private float _transparency;
    private int _minCenter;
    private int _maxCenter;
    private int _score;
    private int _currentMarkerIndex;
    private bool _isVertical;
    private float _center;

    private float transparencyProgress { get => Mathf.Lerp(0.5f, 0, Mathf.Abs(_currentMarkerIndex - _center) / (_center)); }


    private void UpdateLine()
    {
        _line = _isVertical ? _verticalLine : _horizontallLine;
        _center = Mathf.Floor(_line.Length / 2);
        _minCenter = (int)(_center - _accuracy);
        _maxCenter = (int)(_center + _accuracy);
    }
    public void StartGame(Sprite normalPhoto, Sprite blurryPhoto)
    {
        Time.timeScale = 0f;

        _score = 0;
        _transparency = 0;
        _currentMarkerIndex = 0;
        _isVertical = false;
       
        foreach (var marker in _verticalLine)
        {
            marker.color = Color.white;  
        }
        foreach (var marker in _horizontallLine)
        {
            marker.color = Color.white;
        }

        _background.sprite = blurryPhoto;
        _normalPhoto.sprite = normalPhoto;
        _blurryPhoto.sprite = blurryPhoto;
       
        UpdateLine();

        gameObject.SetActive(true);
    }
    private void Update()
    {
        _line[_currentMarkerIndex].color= Color.white;
        _currentMarkerIndex = (int) Mathf.PingPong(Time.unscaledTime * _speed, _line.Length);
        _line[_currentMarkerIndex].color = IsWinIndex(_currentMarkerIndex) ? Color.green : Color.red;
        var color = _blurryPhoto.color;
        color.a = 1 - (_transparency + transparencyProgress);
        _blurryPhoto.color = color;
    }
    private bool IsWinIndex(int index)
    {
        return index >= _minCenter && index <= _maxCenter;
    }
    public void Click()
    {
        if (IsWinIndex(_currentMarkerIndex))
        {
            _score++;
        }
        _transparency = transparencyProgress;
        if (_isVertical)
        {
            Time.timeScale = 1f;
            PhotoSystem.PhotoTaked(_score == 2);
            gameObject.SetActive(false);
        }
        else
        {
            _isVertical = true;
            UpdateLine();
            _currentMarkerIndex = 0; 
        }
    } 
}
