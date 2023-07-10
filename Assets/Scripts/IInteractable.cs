using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    enum InteractableType { Sonar, TakePhoto, PickUpItem, Chat}
    public InteractableType Type { get; }
    public bool IsAvailable { get; }
    public void Interact();
    
}
