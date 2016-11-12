using UnityEngine;
using System.Collections;

public class If_Statements : MonoBehaviour
{

    public float starDropRate = 1;
    public float starMin = 5;
    public float starMax = 20;


    void Start()
    {

    }
    
    void Update()
    {
        if (starDropRate > starMax)
        {
            Debug.Log("There are too many stars!");
        }

        else if (starDropRate < starMin)
        {
            Debug.Log("There aren't enough stars!");
        }

        else
        {
            Debug.Log("You have a good amount of stars.");
        }
    }
}
