using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogGraph;


    private void Start()
    {
        dialogBehaviour.StartDialog(dialogGraph);
    }
}
