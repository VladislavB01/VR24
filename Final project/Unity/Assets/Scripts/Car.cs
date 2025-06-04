using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private GameObject box;
    [NonSerialized]
    public bool isMoving = false;
    public Arm2 test;

    private void Update()
    {
        if (isMoving)
        {
            box.transform.position = gameObject.transform.position;
            box.transform.rotation = gameObject.transform.rotation;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            isMoving = true;
            test.Catched = false;
            test.InBucket = true;
            box = other.gameObject;
        }
    }
}