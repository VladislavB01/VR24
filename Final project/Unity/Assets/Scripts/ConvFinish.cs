using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ConvFinish : MonoBehaviour
{
    public ConvStart test;
    public bool car_isAnimate = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            test.ReadyToMove = false;
        }
    }
}
