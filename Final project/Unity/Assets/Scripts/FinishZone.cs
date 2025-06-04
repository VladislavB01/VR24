using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    public Car test;
    public Button2 test2;
    public Arm2 test3;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            test.isMoving = false;
            test2.arm2_ReadyToAnim = true;
            test3.InBucket = false;
        }
    }
}
