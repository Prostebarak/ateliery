using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forward = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        bool isRunning = animator.GetBool("isRunning");
        bool forward_sprint = Input.GetKey(KeyCode.LeftShift);
        bool isSprinting = animator.GetBool("isSprinting");
        bool jump = Input.GetKey(KeyCode.Space);

        if (forward && !isRunning)
        {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && !forward)
        {
            animator.SetBool("isRunning", false);
        }

        if (!isSprinting && forward && forward_sprint)
        {
            animator.SetBool("isSprinting", true);
        }

        if (isSprinting && (!forward || !forward_sprint))
        {
            animator.SetBool("isSprinting", false);
        }

        if (jump)
        {
            animator.SetTrigger("isJumping");
        }
    }
}
