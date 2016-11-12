//The UnityEngine is a namespaces and the System.Collectiions is a name space.
//They allow us to use the functions an classes that have already been created in that particular name space.
using UnityEngine;
using System.Collections;

//Classes:
//A class shows us all of the different functions, statements, and comments we have in a script.

public class Conventions_Syntax : MonoBehaviour {

	//Function:
    //A function holds all of the instructions for this specific part of the script.

    //Statments are single lines of code of simple instructions within functions.

	void Start ()
    {
        Debug.Log("This is a statement. It will only be called once.");
	    
        //Start only uses statments inside of it one time.

        //The dot operator (such as the period in between Debug and Log above) is a stop inbetween lines.
        //It allows you to access separate elements of the line of code.

        //The semicolon is used to stop statements.
        //Anything using a curly brace doesn't need semicolons.
        
        //Indenting helps readability. It isn't necessary, but it's nice to look at.

	}
	
	
	void Update ()
    {
        /*
        Debug.Log("This will repeat until the game is stopped");
        Debug.Log("Hey look, a block of code!");
        Debug.Log("This block of code will also repeat into the infinities because it is in Update.");
        */

        //Update will run that statment inside of it over and over again for every frame.

        //Comments are useful for making notes, giving directions, and helping during the debug stage.
        //If you would like to comment out a large section of code, use the multi-line comment. An example of this is on the block of code above. Now the block of code won't run because Unity can't see it.

        //When debuging, you can comment out issues to help figure out what is going wrong and to get your stuff back into working order.
        //Comments are ignored by code, so you can literally type whatever you want and it will not affect your game.
    }
}
