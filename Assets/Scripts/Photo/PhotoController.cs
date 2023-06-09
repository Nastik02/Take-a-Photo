﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PhotoController : MonoBehaviour
    {
        public Animator animator;
        public Transform firstPoint;
        public GameObject FirstCheckPoint;
        public GameObject photoicon1;
        public GameObject photoicon2;
        public GameObject photoicon3;
        public Transform secondPoint;
        public Transform thirdPoint;
        public GameObject albMenu;
        public AudioSource sound;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            /*if (Vector2.Distance(transform.position, firstPoint.transform.position) < 2f)
            {
                animator.SetBool("IsExited", true);
            }*/
            if (Vector2.Distance(transform.position, firstPoint.transform.position) < 2f && Input.GetKey(KeyCode.F))
            {
                /*animator.SetBool("IsExited", false);*/
                photoicon1.SetActive(true);
                animator.SetTrigger("takePhoto");
                firstPoint.SendMessage("Destroy");
                sound.Play();
            }
            if (Vector2.Distance(transform.position, secondPoint.transform.position) < 2f && Input.GetKey(KeyCode.F))
            {
                photoicon2.SetActive(true);
                animator.SetTrigger("takePhoto");
                secondPoint.SendMessage("Destroy");
                albMenu.SendMessage("Setter");
                sound.Play();
            }
            if (Vector2.Distance(transform.position, thirdPoint.transform.position) < 2f && Input.GetKey(KeyCode.F))
            {
                photoicon3.SetActive(true);
                animator.SetTrigger("takePhoto");
                thirdPoint.SendMessage("Destroy");
                sound.Play();
            }
        }
    }
}