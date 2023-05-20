using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamMovement : MonoBehaviour
{
    public GameObject player;
    [SerializeField]private float LeftLimit;
    [SerializeField] private float RightLimit;
    [SerializeField] private float UpLimit;
    [SerializeField] private float DownLimit;

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2, -10f);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,LeftLimit,RightLimit), Mathf.Clamp(transform.position.y, DownLimit, UpLimit), transform.position.z);
    }


}
