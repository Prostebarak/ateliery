using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjective : MonoBehaviour
{
    public Quest targetQuest; // Odkaz na quest 
    public QuestManager questManager;
    public Quest nextQuest; // Další quest který hráè dostane po splnìní

    public void CompleteQuest()
    {
        if (questManager.activeQuests.Contains(targetQuest) && !targetQuest.isCompleted)
        {
            questManager.CompleteQuest(targetQuest);

            if (nextQuest != null)
            {
                questManager.AddQuest(nextQuest);
            }
        }
    }
}
