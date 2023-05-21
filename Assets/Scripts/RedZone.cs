using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class RedZone : MonoBehaviour
    {
        public GameObject crch;
        public AudioSource scream;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                scream.Play();
                crch.SendMessage("Move");
            }
        }
    }
}