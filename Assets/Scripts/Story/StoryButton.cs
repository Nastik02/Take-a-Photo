using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryButton : MonoBehaviour
{
    [SerializeField] private GameObject _storyMarker;
    private bool _hasNewStory;
    private void Start()
    {
        _storyMarker.SetActive(_hasNewStory);
        StorySystem.OnStoryAdded.AddListener(NewStoryAdded);
    }

    private void NewStoryAdded(string story)
    {
        _hasNewStory = true;
        _storyMarker.SetActive(_hasNewStory);
    }

    public void Click()
    {
        _hasNewStory = false;
        _storyMarker.SetActive(_hasNewStory);
        UI.ShowStoryJournal();
    }
    private void OnDestroy()
    {
        StorySystem.OnStoryAdded.RemoveListener(NewStoryAdded);
    }
}
