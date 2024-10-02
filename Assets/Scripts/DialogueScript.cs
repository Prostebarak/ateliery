using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraph;


    public void dialogueStart()
    {
        dialogBehaviour.StartDialog(dialogGraph);
    }
}
