using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Dialogue", order = 51)]

public class Dialogue : ScriptableObject
{
    [SerializeField] private Phrase[] _phrases;
    [SerializeField] private string _startPhraseId;

    public IEnumerable Phrases { get => _phrases;}
    public string StartPhraseId { get => _startPhraseId;}
}
