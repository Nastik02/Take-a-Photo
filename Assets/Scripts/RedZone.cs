using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class RedZone : MonoBehaviour
    {
        public GameObject crch;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                crch.SendMessage("Move");
            }
        }
    }
}