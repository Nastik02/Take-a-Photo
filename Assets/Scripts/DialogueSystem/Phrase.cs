using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class Phrase
{
    [SerializeField] private string _id;
    [SerializeField] private Person _person;
    [SerializeField][TextAreaAttribute] private string _text;
    [SerializeField] private PhraseAnswer[] _answers;
    [SerializeField] private string _nextPhraseId;

    public Person Person { get => _person;}
    public string Text { get => _text;}
    public string Id { get => _id;}
    public string NextPhraseId { get => _nextPhraseId; }
}

[Serializable]
public class PhraseAnswer
{
    [SerializeField] private string _text;
    [SerializeField] private string _action;
}