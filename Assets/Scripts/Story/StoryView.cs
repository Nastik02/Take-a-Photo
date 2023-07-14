using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryView : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Image _image;

    public void SetStory(Story story)
    {
        _text.text = story.Text;
        var photo = story as Photo;
        if (photo != null)
        {
            _image.sprite = photo.Sprite;
        }
        else
        {
            _image.gameObject.SetActive(false);
        }
    }
}
