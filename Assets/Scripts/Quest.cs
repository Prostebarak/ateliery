using UnityEngine;

[CreateAssetMenu(fileName = "NewQuest", menuName = "Quest System/Quest")]
public class Quest : ScriptableObject
{
    public string questName;
    [TextArea]
    public string description;
    public bool isCompleted;
    public int experienceReward;
    public GameObject rewardItem; // odkaz na pøedmìt jako odmìnu
}