using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ReputationUI : MonoBehaviour
{
    public Sprite bestReputation;
    public Sprite midReputation;
    public Sprite badReputation;
    public Image faceReputation;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = gameObject.GetComponent<Reputation>().reputationValue;
        faceReputation.sprite = badReputation;
    }

    // Update is called once per frame
    void Update()
    {
        Reputation reputation = gameObject.GetComponent<Reputation>();
        slider.value = reputation.reputationValue;

        if (reputation.reputationValue >= 70)
        {
            faceReputation.sprite = bestReputation;
        }

        else if (reputation.reputationValue < 70 && reputation.reputationValue > 40)
        {
            faceReputation.sprite = midReputation;
        }

        else
        {
            faceReputation.sprite = badReputation;
        }
    }
}
