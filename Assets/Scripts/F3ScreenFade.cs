using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class F3ScreenFade : MonoBehaviour
    {
        private Animator anim;

        // Use this for initialization
        void Start()
        {
            anim = GetComponent<Animator>();
            anim.SetBool("fade", false);
        }
        public void die()
        {
            StartCoroutine(DieCoroutine());
        }
        private IEnumerator DieCoroutine()
        {
            anim.SetBool("fade", true);
            yield return new WaitForSeconds(1f);
            anim.SetBool("fade", false);

        }
        public void StartLight()
        {
            StartCoroutine(Light());
        }
        private IEnumerator Light()
        {
            yield return new WaitForSeconds(0.3f);
            anim.SetTrigger("light");
        }

    }
}