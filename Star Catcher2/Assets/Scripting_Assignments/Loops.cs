using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

    public int Wolf = 4;

    void FindWolf()
    {
        for(int i = 0; i < 6; i++)
        {
            Wolf = Random.Range(2, 20);

            if ()
        }
    }

    void Start()
    {

    }
    
    void Update()
    {

    }

    /*
    private int enemyDistance = 0;
	
	void Start ()
    {
	    
	}
	
	
	void Update ()
    {
      
	}

    //a for loop allows us to loop a block of code for a certain amount of time.

    void EnemySearch()
    {
        for (int i = 0; i < 5; i++) //there are semicolons inbetween these statements.
        {
            enemyDistance = Random.Range(1, 10);

            //we will create single if statements not else or else if.
            if(enemyDistance >= 8)
            {
                Debug.Log("An enemy is way over there!");
            }
            if(enemyDistance >= 4 && enemyDistance <= 7)
            {
                Debug.Log("That enemy is getting closer");
            }
            if(enemyDistance < 4)
            {
                Debug.Log("This enemy has terrible breath");
            }

            //this if set up makes it so the code isn't run through everything over and over, but just sees the statement and then goes back.
        }
    }
    */
}
