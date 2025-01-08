using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjective : MonoBehaviour
{
    public Quest targetQuest; // Odkaz na quest 
    public QuestManager questManager;
    public Quest nextQuest; // Dal�� quest kter� hr�� dostane po spln�n�

    private void CompleteQuest()
    {
        questManager.CompleteQuest(targetQuest);
        Debug.Log($"Quest spln�n: {targetQuest.questName}");

        if (nextQuest != null)
        {
            questManager.AddQuest(nextQuest);
            Debug.Log($"Nov� quest p�ijat: {nextQuest.questName}");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            // Zkontroluje jestli hr�� m� tento quest
            if (questManager.activeQuests.Contains(targetQuest) && !targetQuest.isCompleted)
            {
                CompleteQuest();
               
            }
        }
    }
}

