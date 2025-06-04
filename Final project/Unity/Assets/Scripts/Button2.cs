using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public Animator anim_car;
    public Animator anim_arm;
    public bool arm2_ReadyToAnim = true;

    private void OnMouseDown()
    {
        anim_car.SetTrigger("Forward");

        if (arm2_ReadyToAnim)
        {
            anim_arm.SetTrigger("Ready");
            arm2_ReadyToAnim = false;
        }
    }
}