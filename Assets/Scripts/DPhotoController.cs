using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class DPhotoController : MonoBehaviour
    {
        public Animator animator;
        public Transform firstPoint;
        public GameObject creature;
       
        void Update()
        {
            if (Vector2.Distance(transform.position, firstPoint.transform.position) < 1f && Input.GetKey(KeyCode.F))
            {
                //photoicon1.SetActive(true);
                animator.SetTrigger("takePhoto");
                firstPoint.SendMessage("Destroy");
                Destroy(creature);
            }
        }
    }
}