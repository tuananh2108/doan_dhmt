using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float jumpLimit = 50.0f;
    public static float leftSide = -3.0f;
    public static float rightSide = 3.0f;
    public float internalLeft;
    public float internalRight;
    public float internalTop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalTop = jumpLimit;
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
