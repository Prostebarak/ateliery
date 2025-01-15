using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public DialogBehaviour dialogBehaviour;
    public DialogNodeGraph dialogGraph;
    public QuestManager questManager;

    private void Update()
    {
        dialogGraph = questManager.activeQuests[0].dialog;
    }
    public void dialogueStart()
    {
        dialogBehaviour.StartDialog(dialogGraph);
    }


}
