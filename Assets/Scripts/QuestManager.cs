using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> activeQuests = new List<Quest>();
    public List<Quest> allQuests = new List<Quest>();

    private void Start()
    {
        foreach (Quest quest in allQuests)
        {
            if (quest.isCompleted)
            {
                quest.isCompleted = false;
            }
        }
    }
    public void AddQuest(Quest quest)
    {
        if (!activeQuests.Contains(quest))
        {
            activeQuests.Add(quest);
            Debug.Log($"Quest pøidán: {quest.questName}");
        }
    }

    public void CompleteQuest(Quest quest)
    {
        if (activeQuests.Contains(quest))
        {
            quest.isCompleted = true;
            activeQuests.Remove(quest);
            Debug.Log($"Quest splnìn: {quest.questName}");
        }
    }
}
