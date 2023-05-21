using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

namespace Assets.Scripts
{
    public class SonarRotate : MonoBehaviour
    { 
        private Transform sweepTransform;
        private float rotationSpeed = 360f;
        public GameObject effect;
        public GameObject crEffect;
        public GameObject cr2Effect;

        private void Awake()
        {
            sweepTransform = transform.Find("Sweep");
        }
        private void FixedUpdate()
        {
            float angle = transform.eulerAngles.z;
            transform.Rotate(0,0,rotationSpeed*Time.fixedDeltaTime);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
            if (hit && hit.collider.gameObject.CompareTag("Ground"))
            {
                
                Instantiate(effect, hit.point, Quaternion.identity);
            }
            if (hit && hit.collider.gameObject.CompareTag("Creature1"))
            {
                Instantiate(crEffect, hit.point, Quaternion.identity);
            }
            if (hit && hit.collider.gameObject.CompareTag("Creature2"))
            {
                Instantiate(cr2Effect, hit.point, Quaternion.identity);
            }
        }
        private void Update()
        {
            //Ray ray = new Ray(transform.position, transform.right);
            /*ray.origin = transform.position;
            ray.direction = transform.right;
            Debug.DrawRay(transform.position, transform.right, Color.yellow);*/
            /*RaycastHit hit;
            Physics2D.Raycast(transform.position, transform.right);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("1");
                Instantiate(effect, hit.point, Quaternion.identity);
            }*/
            //Debug.DrawRay(transform.position, transform.right*100f, Color.yellow);
           /* RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
            if (hit&& hit.collider.gameObject.CompareTag("Ground"))
            {
                Instantiate(effect, hit.point, Quaternion.identity);
            }*/
            
        }

        /*void Update()
        {
            sweepTransform.eulerAngles += new Vector3(0,0, rotationSpeed*Time.deltaTime);
        }*/
    }
}