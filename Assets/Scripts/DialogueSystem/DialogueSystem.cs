using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    private static DialogueSystem instance;
    private static Dialogue _dialogue;
    private static string _currentPhraseId = "0001";

    public static Dialogue Dialogue { get { return _dialogue; } set { _dialogue = value; } }

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
    }

    public static void StartDialogue()
    {
        Phrase startPhrase = null;
        foreach (Phrase phrase in Dialogue.Phrases){
            if(phrase.Id == Dialogue.StartPhraseId)
            {
                startPhrase = phrase;
                break;
            }
        }
        UI.ShowPhrase(startPhrase);
    }
    public static void ContinueDialogue()
    {
        Debug.Log("кнопка нажата");
        Phrase currentPhrase = null;
        foreach (Phrase phrase in Dialogue.Phrases)
        {
            if (phrase.Id == _currentPhraseId)
            {
                currentPhrase = phrase;
                break;
            }
        }
        if (currentPhrase != null)
        {
            UI.ShowPhrase(currentPhrase);
            _currentPhraseId = currentPhrase.NextPhraseId;
        }
        else
        {
            UI.ClosePanel();
        }
    }
}
