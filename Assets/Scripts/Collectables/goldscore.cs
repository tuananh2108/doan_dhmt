using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldscore : MonoBehaviour
{
    public static int score;
    public GameObject scoreDisplay;
   
    // Update is called once per frame
    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "" + score;


    }
}
