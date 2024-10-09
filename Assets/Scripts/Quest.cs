using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public string questName;
    public string questDescription;
    public bool isCompleted;

    public Quest(string name, string description)
    {
        questName = name;
        questDescription = description;
        isCompleted = false;
    }

    public void Completequest()
    {
        isCompleted = true;
        Debug.Log($"Quest {questName} completed!");
    }
}
