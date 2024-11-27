using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest; // Quest, který NPC zadává
    public QuestManager questManager; // Správce questù

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (quest != null && questManager != null)
            {
                questManager.AddQuest(quest);
                Debug.Log($"Quest pøijat: {quest.questName}");
            }
            else
            {
                Debug.LogError("Chybí odkaz na Quest nebo QuestManager!");
            }
        }
    }
}
