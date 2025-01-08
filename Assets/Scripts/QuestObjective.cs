using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjective : MonoBehaviour
{
    public Quest targetQuest; // Odkaz na quest 
    public QuestManager questManager;
    public Quest nextQuest; // Další quest který hráè dostane po splnìní

    private void CompleteQuest()
    {
        questManager.CompleteQuest(targetQuest);
        Debug.Log($"Quest splnìn: {targetQuest.questName}");

        if (nextQuest != null)
        {
            questManager.AddQuest(nextQuest);
            Debug.Log($"Nový quest pøijat: {nextQuest.questName}");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            // Zkontroluje jestli hráè má tento quest
            if (questManager.activeQuests.Contains(targetQuest) && !targetQuest.isCompleted)
            {
                CompleteQuest();
               
            }
        }
    }
}

