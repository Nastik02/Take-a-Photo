using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    [SerializeField] private Dialogue _dialogue;
    public IInteractable.InteractableType Type => IInteractable.InteractableType.Chat;

    public bool IsAvailable => true;

    public void Interact()
    {
        DialogueSystem.Dialogue = _dialogue;
        DialogueSystem.StartDialogue();
    }
}
