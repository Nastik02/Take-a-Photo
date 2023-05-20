using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class CamMovement : MonoBehaviour
    {
        public GameObject player;
        void LateUpdate()
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2, -10f);
        }


    }
