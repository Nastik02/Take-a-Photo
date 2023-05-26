using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Assets.Scripts 
{
    public class ExitGame : MonoBehaviour
    {
        public void Exit()
        {
            Application.Quit();
        }
    }
}