using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerUpLimiter : MonoBehaviour
    {
        private float playerUpLimit=-1.5f;
        private Rigidbody2D rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();

        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(transform.position.y>playerUpLimit)
            {
                rb.gravityScale = 10f;
            }
            if(transform.position.y<=playerUpLimit)
            {
                rb.gravityScale = 0f;
            }
        }
    }
}