using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos=3000;
    public bool creatingSection = false;
    public int secnum;
    

    // Update is called once per frame
    void Update()
    {
      if(creatingSection==false)
        {
            creatingSection = true;
            StartCoroutine(generateSection());
        }
    }
    IEnumerator generateSection()
    {
        secnum = Random.Range(0, 2);
        Instantiate(section[secnum], new Vector3(501, 0, zPos), Quaternion.identity);
        zPos += 3000;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
