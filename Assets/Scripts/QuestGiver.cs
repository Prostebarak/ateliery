using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest; // Quest, kter� NPC zad�v�
    public QuestManager questManager; // Spr�vce quest�

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (quest != null && questManager != null)
            {
                questManager.AddQuest(quest);
                Debug.Log($"Quest p�ijat: {quest.questName}");
            }
            else
            {
                Debug.LogError("Chyb� odkaz na Quest nebo QuestManager!");
            }
        }
    }
}
