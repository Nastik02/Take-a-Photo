using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class DPhotoController : MonoBehaviour
    {
        public Animator animator;
        public Transform firstPoint;
        public GameObject creature;
        public GameObject photoicon;
        public AudioSource sound;
        public GameObject cam;
        private bool canTakePhoto=true;

        void Update()
        {
            if (Vector2.Distance(transform.position, firstPoint.transform.position) < 1f && Input.GetKey(KeyCode.F)&&canTakePhoto)
            {
                canTakePhoto= false;
                photoicon.SetActive(true);
                animator.SetTrigger("takePhoto");
                firstPoint.SendMessage("Destroy");
                sound.Play();
                Destroy(creature);
                cam.SendMessage("StartLight");
            }
        }
        
    }
}