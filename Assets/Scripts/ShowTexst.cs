using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowTexst : MonoBehaviour
{
        public GameObject arrow;
        public Transform player;
        

        // Use this for initialization
        void Start()
        {
            arrow.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {
            if(arrow!= null)
            {
                if (Vector2.Distance(transform.position, player.transform.position) < 4f)
                {
                    arrow.SetActive(true);
                }
                if (Vector2.Distance(transform.position, player.transform.position) > 4f)
                {
                    arrow.SetActive(false);
                }
            }
            

        }
        public void Destroy()
        {
        Destroy(arrow.gameObject);
        }

}
