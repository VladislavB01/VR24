using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public ConvStart test;
    public StartZone test2;

    private void OnMouseDown()
    {
        test.ReadyToMove = true;
        test2.arm1_ReadyToAnim = true;
    }
}