using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator.enabled = false;
    }
    private void OnTriggerStay(Collider other)
    {
        bool pressedE = Input.GetKey(KeyCode.E);
        if (pressedE)
        {
            animator.enabled = true;
        }
    }

}
