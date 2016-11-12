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
    

    //VIDEO NOTES:

    /*
    
    VIDEO 1 & 2:
    
    //we need the f to recognize the decimal value.

    public float speed = 0.0f;
    public float distance = 210.0f;
    public float time = 3.0f;
    public float maxSpeedLimit = 70.0f;
    public float minSpeedLimit = 40.0f;
	
	void Start ()
    {
	    
	}
	
	
	void Update ()
    {
        speed = distance / time;
        if (speed > maxSpeedLimit)
        {
            //if statements require conditions (speed > maxSpeedLimit)
            Debug.Log("You are exceeding the speed limit!");
        }

        //else if statements won't be executed if the if statement isn't satisfied.
        //else if statements are extensions of the if statements.

        else if (speed < minSpeedLimit) //you can use as many else if conditions that you like.
        {
            Debug.Log("You are not going fast enough");
        }

        else if (speed == maxSpeedLimit || speed == minSpeedLimit)
        {
            Debug.Log("You are close to breaking the law.");
        }
        
        //else statements are the default.

        else
        //else statements don't need conditions because they look at the if statements above it.
        {
            Debug.Log("You are within the speed limit");
        }
            
	}
    */
}
