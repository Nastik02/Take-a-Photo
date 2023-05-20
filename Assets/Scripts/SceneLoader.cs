using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneLoader : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("1");
                SceneManager.LoadScene(1);
            }
        }
    }
}