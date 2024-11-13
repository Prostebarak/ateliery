using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReputationUI : MonoBehaviour
{
    public Sprite bestReputation;
    public Sprite midReputation;
    public Sprite badReputation;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().sprite = badReputation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
