using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest; // Quest, kter� NPC zad�v�
    public QuestManager questManager; // Spr�vce quest�

    public void GiveQuest()
    {
        
        if (quest != null && questManager != null)
        {
            questManager.AddQuest(quest);
                
        }
        else
        {
            Debug.LogError("Chyb� odkaz na Quest nebo QuestManager!");
        }
        
    }
}
