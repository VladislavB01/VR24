using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class ConvStart : MonoBehaviour
{
    public Arm1 test;
    private GameObject box;
    public float speed_ = 1.0f;
    [NonSerialized]
    public bool ReadyToMove = false;

    void Update()
    {
        if (ReadyToMove)
        {
            box.transform.Translate(Vector3.forward * speed_ * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;
            box = other.gameObject;
            test.Catched = false;
            test.OnConv = true;
        }
    }
}
