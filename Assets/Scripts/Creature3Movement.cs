using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Creature3Movement : MonoBehaviour
    {
        public Transform player;
        private bool canChase = false;


        
        void Update()
        {
            if (canChase)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, 15 * Time.deltaTime);
            }
            //transform.position = Vector3.MoveTowards(transform.position, player.position, 8 * Time.deltaTime);
            /*if (Vector2.Distance(transform.position, player.position) < 10f)
            {
                Debug.Log("2");
                transform.position = Vector3.MoveTowards(transform.position, player.position, 8 * Time.deltaTime);
            }*/
        }
        public void Move()
        {
            canChase= true;
        }
    }
}