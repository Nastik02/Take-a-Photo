using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSystem : MonoBehaviour
{
    [SerializeField] private PhotoFrames _frames;
    [SerializeField] private PhotoGame _photoGame;
    private static PhotoSystem instance = null;
    private static PhotoLocation _currentLocation;

    public static bool HasFrames { get { return instance._frames.Value > 0; } }

    
    private void Awake()
    { 
        if (instance == null)
        { 
            instance = this; 
        }
        else if (instance != null)
        {
            Debug.LogError("Multiple instance singltone photosystem");
        }
    }
    public static bool TryTakePhoto(PhotoLocation location)
    {
        _currentLocation = location;
        if (HasFrames)
        {
            instance._photoGame.StartGame(location.SuccessfulPhoto.Sprite, location.FailedPhoto.Sprite);
            return true;
        }
        else
        {
            Debug.Log("you don't have frames");
            return false;
        }
    }
    public static void PhotoTaked(bool success)
    {
        instance._frames.Take();
        _currentLocation.IsTaked = true;
        if (success)
        {
            Debug.Log("success Photo");
            StorySystem.AddStory(_currentLocation.SuccessfulPhoto.Id);
        }
        else
        {
            Debug.Log("failed Photo");
            StorySystem.AddStory(_currentLocation.FailedPhoto.Id);
        }
    }
}
