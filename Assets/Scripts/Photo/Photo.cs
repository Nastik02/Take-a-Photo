using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PhotoData", menuName = "Photo", order = 51)]

public class Photo : Story
{
    [SerializeField] private Sprite _photo;

    public Sprite Sprite { get => _photo; }
}
