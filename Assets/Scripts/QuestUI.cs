using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    public QuestManager questManager;
    public TextMeshProUGUI questText;

    void Update()
    {
        questText.text = "";
        foreach (Quest quest in questManager.quests)
        {
            string status = quest.isCompleted ? "(Completed)" : "(In Progress)";
            questText.text += quest.questName + status + "\n";

        }
    }
}
