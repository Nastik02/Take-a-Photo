using System.Collections;
using UnityEngine;
using UnityEngine.UI;


namespace Assets.Scripts
{
    public class LoadScene : MonoBehaviour
    {
        public Animator anim;

        
        private void Start()
        {
            Debug.Log("7");
            anim.SetTrigger("start");
            
        }
        
    }
}