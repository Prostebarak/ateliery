using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reputation : MonoBehaviour
{
    public int reputationValue = 0;

    public void ChangeReputation(int value)
    {
        reputationValue += value;
    }

}
