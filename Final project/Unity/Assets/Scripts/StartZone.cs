using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartZone : MonoBehaviour
{
    public Animator anim_;
    public bool arm1_ReadyToAnim = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;

            if (arm1_ReadyToAnim)
            {
                anim_.SetTrigger("Ready");
                arm1_ReadyToAnim = false;
            }
        }
    }
}