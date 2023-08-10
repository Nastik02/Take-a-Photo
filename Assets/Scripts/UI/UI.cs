using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    private static UI instance;

    [SerializeField] private StoriesJournal _storyJournal;
    [SerializeField] private DialoguePanel _dialoguePanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.LogError("Multiple instance singltone UI");
        }
    }

    public static void ShowStoryJournal()
    {
        var journal = instance._storyJournal.gameObject;
        journal.SetActive(!journal.activeSelf);
    }

   public static void ShowPhrase(Phrase phrase)
    {
        instance._dialoguePanel.Say(phrase.Person.Name, phrase.Person.Avatar, phrase.Text);
    }
    public static void ClosePanel()
    {
        instance._dialoguePanel.CloseDialoguePanel();
    }
}
