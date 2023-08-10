using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Person", menuName = "Dialogue/Person", order = 51)]


public class Person : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Sprite _avatar;

    public string Name { get => _name;}
    public Sprite Avatar { get => _avatar;}
}
