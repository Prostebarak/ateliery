using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionCamera : MonoBehaviour
{
    public Rigidbody rb;
    public InteractionScript interactionScript; // Reference to interaction script
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Cursor.lockState == CursorLockMode.None)
        {
            print(Cursor.lockState);
        }
        if (interactionScript.dialogueRunning == true)
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None; // Unlock the cursor
                Cursor.visible = true;                 // Make the cursor visible
                rb.freezeRotation = true;              //fixes rotating while in dialog

            }

        }
        else if (interactionScript.dialogueRunning == false)
        {
            Cursor.lockState = CursorLockMode.Locked; // Lock the cursor again
            Cursor.visible = false;                   // Hide the cursor

        }

    }
}
