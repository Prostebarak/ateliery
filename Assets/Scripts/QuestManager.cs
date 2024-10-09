using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();
    void Start()
    {
        Quest quest1 = new Quest("Find the lost sword", "Find the sword in the forest");
        quests.Add(quest1);
    }

    public void CompleteQuest(string questName)
    {
        Quest quest = quests.Find(q => q.questName == questName);
        if (quest != null)
        {
            quest.Completequest();
        }
        else
        {
            Debug.LogWarning($"Quest {questName} not found!");
        }
    }
}
