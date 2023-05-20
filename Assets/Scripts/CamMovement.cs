using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamMovement : MonoBehaviour
{
    public GameObject player;
    private float LeftLimit=-0.51f;
    private float RightLimit=34;
    private float UpLimit=-1.37f;
    private float DownLimit=-8.79f;

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2, -10f);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,LeftLimit,RightLimit), Mathf.Clamp(transform.position.y, DownLimit, UpLimit), transform.position.z);
    }


}
