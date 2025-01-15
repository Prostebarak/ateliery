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
    public Quest targetQuest;
    public QuestManager questManager;
    public QuestObjective questObjective;


    void DialogueFinished()
    {
        dialogueRunning = false;
        interactionControler.anyDialogRunning = false;
        questObjective.CompleteQuest();
    }


    void OnTriggerStay(Collider other)
    {

        if (questManager.activeQuests.Contains(targetQuest)) // checks if the target quest that plays is in active quests
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
}
