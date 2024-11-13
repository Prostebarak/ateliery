using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reputation : MonoBehaviour
{
    public int reputationValue = 50;

    public void increaseReputation(int increaseValue)
    {
        reputationValue += increaseValue;
    }

    public void decreaseReputation(int decreaseValue)
    {
        reputationValue -= decreaseValue;
    }
}
