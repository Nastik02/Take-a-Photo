using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Creature2Movement : MonoBehaviour
    {
        public Transform[] waypoints;
        private int _currentInd;
        private float speed = 2f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Transform wp = waypoints[_currentInd];
            if(Vector2.Distance(transform.position, wp.position) < 0.01f )
            {
                if (_currentInd < 2)
                {
                    _currentInd++;
                }
                else
                {
                    _currentInd = 0;
                }
                
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, wp.position, speed*Time.deltaTime);
            }
        }
    }
}