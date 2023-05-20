using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbomMenu : MonoBehaviour
{
    public GameObject albom;
    public GameObject firstphotomenu;
    public GameObject secondphotomenu;
    public GameObject thirdphotomenu;
    public GameObject firstbutton;
    public GameObject secondbutton;
    public bool issecondopen=false;

    public void Setter()
    {
        issecondopen = true;
    }
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
        firstbutton.SetActive(false);
        secondbutton.SetActive(false);
    }
    public void SetFirstPhotoMenuClose()
    {
        firstphotomenu.SetActive(false);
        firstbutton.SetActive(true);
        if (issecondopen) {
            secondbutton.SetActive(true);
        }
        
    }
    public void SetSecondPhotoMenuActive()
    {
        secondphotomenu.SetActive(true);
        secondbutton.SetActive(false);
    }
    public void SetSecondPhotoMenuClose()
    {
        secondphotomenu.SetActive(false);
        if (issecondopen)
        {
            secondbutton.SetActive(true);
        }
    }
    public void SetThirdPhotoMenuActive()
    {
        secondbutton.SetActive(false);
        thirdphotomenu.SetActive(true);
    }
    public void SetThirdPhotoMenuClose()
    {
        thirdphotomenu.SetActive(false);
        if (issecondopen)
        {
            secondbutton.SetActive(true);
        }
    }

}
