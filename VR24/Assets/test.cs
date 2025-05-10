using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Animator anim_;
    private void OnMouseDown()
    {
        anim_.SetTrigger("StartAnimation");
    }
}
