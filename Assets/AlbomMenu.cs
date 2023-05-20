using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbomMenu : MonoBehaviour
{
    public GameObject albom;
    public GameObject firstphotomenu;
   
    public void Pause()
    {
        albom.SetActive(true);
        Time.timeScale=0f;
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        albom.SetActive(false);
    }
    public void SetFirstPhotoMenuActive()
    {
        firstphotomenu.SetActive(true);
    }
    public void SetFirstPhotoMenuClose()
    {
        firstphotomenu.SetActive(false);
    }
}
