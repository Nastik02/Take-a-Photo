using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ShowInstr : MonoBehaviour
    {

        public GameObject arrow;
        public Transform player;


        
        void Update()
        {
            if (arrow != null)
            {
                if (Vector2.Distance(transform.position, player.transform.position) < 3f)
                {
                    arrow.SetActive(true);
                }
                if (Vector2.Distance(transform.position, player.transform.position) > 3f)
                {
                    arrow.SetActive(false);
                }
            }


        }
     
    }
}