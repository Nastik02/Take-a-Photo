using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static IInteractable;

public class InteractButton : MonoBehaviour
{
    [Serializable]
    public struct InteractableIcon
    {
        public InteractableType Type;
        public Sprite Icon;
    }
    [SerializeField] private PlayerController _player;
    [SerializeField] private GameObject _container;
    [SerializeField] private Image _icon;
    [SerializeField] private InteractableIcon[] _icons;
    private Dictionary<InteractableType, Sprite> _iconTypes = new Dictionary<InteractableType, Sprite>();

    private void Awake()
    {
        foreach (var icon in _icons)
        {
            _iconTypes.TryAdd(icon.Type, icon.Icon);
        }
        _icons = null;
    }
    private void Start()
    {
        _container.SetActive(false);
        _player.OnEnterIntractableZone.AddListener(PlayerEnterInteractZone);
        _player.OnExitIntractableZone.AddListener(PlayerExitInteractZone);
    }
    private void PlayerEnterInteractZone(IInteractable interactable)
    {
        _icon.sprite = _iconTypes[interactable.Type];
        _container.SetActive(true);
    }
    private void PlayerExitInteractZone()
    {
        _container.SetActive(false);
    }
    public void Press()
    {
        _player.TryInteract();
    }

}
