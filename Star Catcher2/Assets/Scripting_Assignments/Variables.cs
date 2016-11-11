using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {


    public int stars = 5;
    public int starFallSpeed = 10;
    private int starSpeed;
    int star = 8;

    void Start()
    {

    }

    void Update()
    {

    }


    //Video Notes:

    //VIDEO 1:
    //The access modifier tells who can access this variable.
    //public = exposed in unity & everyone can access it.
    //private = not exposed in unity and only you can access it.

    //After the access modifier is the modifiers.
    //const = constant = value of local variable cannot be modified.

    //Next is the Type = tells variable what type of data the variable will hold.
    //Int = integer = full number value.
    //float for a decible value.

    //Identifyier = name for the variable (can be anything we want such as speed)
    // can't use while or if or for (would contradict the API (automated programming interface))
    // must begin with a letter or an underscore. Can contain letters, numbers, or punctuation, but only after the first letter.
    //cannot contain spaces (such as max speed) instead you would type maxSpeed.
    
    // every identifier needs to be assigned to a data vaule. = is the assignment operator.
    // then you need to give it a value or data.
    //after that you have the semicolon. A vaurable is like a statment. It must end with a semicolon.

    //public int speed = 1;


    //VIDEO 2:

    //Variables can be compared to boxes that contain information. You need a different box for each bit of information you have.
    //Start with what type of box yuo would like (int (interger, meaning a whole number))
    //Then name the box.
    //Then semicolon the end
    //or you can give the box a value to store and then the semicolon.

    //type nameOfVariable = value;

    //int myInts;
    //or
    //int myInt = 5;


    
}
