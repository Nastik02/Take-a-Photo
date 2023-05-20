using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class CamLimiter : MonoBehaviour
    {
        private float LeftLimit = -0.51f;
        private float RightLimit = 34;
        private float UpLimit = -1.37f;
        private float DownLimit = -8.79f;
        void LateUpdate()
        {
           
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, LeftLimit, RightLimit), Mathf.Clamp(transform.position.y, DownLimit, UpLimit), transform.position.z);
        }

    }
}