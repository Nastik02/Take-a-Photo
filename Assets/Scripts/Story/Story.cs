using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New StoryData", menuName = "Story", order = 51)]

public class Story : ScriptableObject
{
    public string Id { get => name; }
    public string Text { get => _text; }

    [SerializeField] private string _text;
}