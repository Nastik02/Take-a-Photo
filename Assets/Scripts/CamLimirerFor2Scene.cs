using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class CamLimirerFor2Scene : MonoBehaviour
    {
        private float LeftLimit= 32.8f;
        private float RightLimit=33.5f;
        private float UpLimit= -5;
        private float DownLimit=-59;
        void LateUpdate()
        {

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, LeftLimit, RightLimit), Mathf.Clamp(transform.position.y, DownLimit, UpLimit), transform.position.z);
        }

    }
}