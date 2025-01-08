using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    public TextMeshPro interactionText;
    bool eAlreadyPressed = false;
    public bool dialogueRunning = false;
    public InteractionControler interactionControler;
    public DialogueScript dialogueScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DialogueFinished()
    {
        dialogueRunning = false;
        interactionControler.anyDialogRunning = false;
    }


    void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            bool pressedE = Input.GetKey(KeyCode.E);
            
            MeshRenderer meshRendererText = interactionText.GetComponent<MeshRenderer>();
            if (pressedE && eAlreadyPressed == false)
            {
                if (dialogueScript != null)
                {
                    interactionControler.anyDialogRunning = true;
                    dialogueRunning = true;
                    eAlreadyPressed = true;
                    meshRendererText.enabled = false;
                    dialogueScript.dialogueStart();
                    dialogueScript.dialogBehaviour.AddListenerToDialogFinishedEvent(DialogueFinished);
                }
                
            }
            

        }
    }
}
