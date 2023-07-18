using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialoguePanel : MonoBehaviour
{
    [SerializeField] private GameObject _namePanel;
    [SerializeField] private GameObject _avatarPanel;
    [SerializeField] private Image _avatar;
    [SerializeField] private Text _message;
    [SerializeField] private Text _name;

    public void Say(string name, Sprite avatar, string message)
    {
        _namePanel.SetActive(!string.IsNullOrEmpty(name));
        _avatarPanel.SetActive(avatar != null);
        _avatar.sprite = avatar;
        _message.text = message;
        _name.text = name;
    }
}
