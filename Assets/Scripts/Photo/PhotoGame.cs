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
    [SerializeField] private float _markerTime = 1f;
    [SerializeField] private float _nextUpdateTime = 0f;
    [SerializeField] private Vector2 _winIndexes;
    private int _score;
    private int _currentMarkerIndex;
    private bool _isVertical;

    public void StartGame(Sprite normalPhoto, Sprite blurryPhoto)
    {
        gameObject.SetActive(true);
        _score = 0;
        _currentMarkerIndex = 0;
        _isVertical = false;
        _background.sprite = blurryPhoto;
        _normalPhoto.sprite = normalPhoto;
        _blurryPhoto.sprite = blurryPhoto;
        Time.timeScale = 0f;

        foreach (var marker in _verticalLine)
        {
            marker.color = Color.white;  
        }
        foreach (var marker in _horizontallLine)
        {
            marker.color = Color.white;
        }
    }
    private void Update()
    {
        var line = _isVertical? _verticalLine: _horizontallLine;
        line[_currentMarkerIndex].color= Color.white;
        _currentMarkerIndex = (int) Mathf.PingPong(Time.unscaledTime*2, line.Length);
        line[_currentMarkerIndex].color = IsWinIndex(_currentMarkerIndex) ? Color.green : Color.red;
        var color = _blurryPhoto.color;
        //color.a = IsWinIndex(_currentMarkerIndex) ? 0f : 1f;
        color.a = Mathf.Lerp(0, 1, Mathf.Abs(_currentMarkerIndex - line.Length/2f)/(line.Length/2f));
        _blurryPhoto.color = color;
    }
    private bool IsWinIndex(int index)
    {
        return index > _winIndexes.x && index < _winIndexes.y;
    }
    public void Click()
    {
        if (IsWinIndex(_currentMarkerIndex))
        {
            _score++;
        }
        if (_isVertical)
        {
            Time.timeScale = 1f;
            PhotoSystem.PhotoTaked(_score == 2);
            gameObject.SetActive(false);
        }
        else
        {
            _isVertical= true;
            _currentMarkerIndex = 0; 
        }
    } 
}
