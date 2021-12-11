using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void Update()
    {
        /*Vector3 targetPos = player.position + offset;
        targetPos.x = 520;
        transform.position = targetPos;*/
        transform.position = player.position + offset;
    }
}
