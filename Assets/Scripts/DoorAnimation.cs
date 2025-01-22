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
    private void OnTriggerEnter(Collider other)
    {
        animator.enabled = true;
    }

}
