using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoriesJournal : MonoBehaviour
{
    [SerializeField] private StoryView _storyPrefab;
    [SerializeField] private RectTransform _container;
    private void Start()
    {
        foreach (var storyId in StorySystem.Stories)
        {
            CreateStoryView(storyId);
        }
        StorySystem.OnStoryAdded.AddListener(CreateStoryView);
        _storyPrefab.gameObject.SetActive(false);
    }

    private void CreateStoryView(string storyId)
    {
        var view = Instantiate(_storyPrefab, _container);
        view.SetStory(StorySystem.GetStory(storyId));
        view.gameObject.SetActive(true);
    }
    private void OnDestroy()
    {
        StorySystem.OnStoryAdded.RemoveListener(CreateStoryView);
    }
}
