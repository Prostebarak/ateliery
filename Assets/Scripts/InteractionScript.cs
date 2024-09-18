using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DialogueScript dialogueScript = other.gameObject.GetComponent<DialogueScript>();
            
            if (dialogueScript != null)
            {
                dialogueScript.dialogueStart();
            }
        }
    }
}
