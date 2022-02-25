using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFollow : MonoBehaviour
{
    public Transform Monster;
    public float curDis;
    void Start()
    {
        
    }

    public void Follow(Vector3 pos, float speed)
    {
        Vector3 position = pos - Vector3.forward * curDis;
        Monster.position = Vector3.Lerp(Monster.position, position, Time.deltaTime * speed / curDis);
    }    
}
