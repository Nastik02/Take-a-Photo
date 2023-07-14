using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StorySystem : MonoBehaviour
{
    private static StorySystem instance;
    [SerializeField] private Story[] _allStories;
    private Dictionary<string, Story> _storiesData = new Dictionary<string, Story>();
    private List<string> _stories = new List<string>();

    public static UnityEvent<string> OnStoryAdded = new UnityEvent<string>();

    public static IEnumerable<string> Stories { get => instance._stories;
    }
    public static void AddStory(string story)
    {
        if (!instance._stories.Contains(story))
        {
            instance._stories.Add(story);
            OnStoryAdded?.Invoke(story);
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.LogError("Multiple instance singltone storysystem");
        }

        foreach(var story in _allStories)
        {
            _storiesData.Add(story.Id, story);
        }
        _allStories = null;

        AddStory("Start");
    }

    public static Story GetStory(string id)
    {
        return instance._storiesData[id];
    }
}
