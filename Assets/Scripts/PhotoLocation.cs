using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoLocation : MonoBehaviour, IInteractable
{
    [SerializeField] private Photo _successfulPhoto;
    [SerializeField] private Photo _failedPhoto;
    private bool _isTaked;
    public bool IsTaked { get => _isTaked; set { _isTaked = value; gameObject.SetActive(!_isTaked); } }

    public IInteractable.InteractableType Type => IInteractable.InteractableType.TakePhoto;

    public bool IsAvailable => !IsTaked; 

    public void Interact()
    {
        IsTaked = true;
    }

   
}
