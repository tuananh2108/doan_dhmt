using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = 501.0f;
    public static float rightSide = 539.0f;
    public float internalLeft;
    public float internalRight;
    public static float jumpLimit = 10.0f;
    public float internalTop;

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
        internalTop = jumpLimit;
    }
}
