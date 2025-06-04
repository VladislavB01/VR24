using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm2 : MonoBehaviour
{
    [NonSerialized]
    public bool Catched = false;
    [NonSerialized]
    public bool InBucket = false;

    public Arm1 test;
    private GameObject box;

    void Update()
    {
        if (Catched)
        {
            box.transform.position = gameObject.transform.position;
            box.transform.rotation = gameObject.transform.rotation;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box") && !InBucket)
        {
            Catched = true;
            test.OnConv = false;
            box = other.gameObject;
        }
    }
}
