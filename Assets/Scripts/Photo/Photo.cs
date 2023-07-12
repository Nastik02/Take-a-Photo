using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PhotoData", menuName = "Photo", order = 51)]

public class Photo : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private Sprite _photo;

    public Sprite Sprite { get => _photo; }
}
