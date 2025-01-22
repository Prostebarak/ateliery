using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjective : MonoBehaviour
{
    public Quest targetQuest; // Odkaz na quest 
    public QuestManager questManager;
    public Quest nextQuest; // Dal�� quest kter� hr�� dostane po spln�n�
    public Reputation reputation;

    public void CompleteQuest()
    {
        if (questManager.activeQuests.Contains(targetQuest) && !targetQuest.isCompleted)
        {
            questManager.CompleteQuest(targetQuest);
            reputation.ChangeReputation(targetQuest.reputation);

            if (nextQuest != null)
            {
                questManager.AddQuest(nextQuest);
            }
        }
    }
}
