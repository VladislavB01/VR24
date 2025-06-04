using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm1 : MonoBehaviour
{
    [NonSerialized]
    public bool Catched = false;
    [NonSerialized]
    public bool OnConv = false;

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
        if (other.gameObject.CompareTag("Box") && !OnConv)
        {
            Catched = true;
            box = other.gameObject;
        }
    }
}
