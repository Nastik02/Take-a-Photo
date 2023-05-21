using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ScreenFade : MonoBehaviour
    {
        private Animator anim;

        // Use this for initialization
        void Start()
        {
            anim= GetComponent<Animator>();
            anim.SetBool("fade", false);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}