using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class SonarController : MonoBehaviour
    {
        public Animator animator;
        public GameObject sonar;

        

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.R))
            {
                StartCoroutine(SetSonarActive());
            }
        }

        private IEnumerator SetSonarActive()
        {
            animator.SetTrigger("makenoise");
            sonar.SetActive(true);
            yield return new WaitForSeconds(1f);
            sonar.SetActive(false);
        }
    }
}