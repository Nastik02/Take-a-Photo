using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    public IInteractable.InteractableType Type => IInteractable.InteractableType.Chat;

    public bool IsAvailable => true;

    public void Interact()
    {
        Debug.Log(name + ": привет!");
    }
}
