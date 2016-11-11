using UnityEngine;
using System.Collections;

public class Functions_Methods: MonoBehaviour {

    public int StarFallSpeed = 10;
    private int stars = 5;
    
    void Start()
    {
        //StarFallSpeed = 20;
        //Debug.Log(StarFallSpeed + 3);

        //Debug.Log(stars * 4);

        StarFallSpeed = AddStarsByFive(StarFallSpeed);
        Debug.Log(StarFallSpeed);

        stars = AddStarsByFive(stars);
        Debug.Log(stars);

    }


    int AddStarsByFive(int numberOfStars)
    {
        int ret;
        ret = numberOfStars + 5;
        return ret;
    }


    void Update()
    {


    }
    

    //Video Notes:
    
    //VIDEO 1:

    // If you want to do something with your variables, you give them functions.


    //int myInt = 5;


    //Start is called when the object the script is attacted to enters the scene.

    //void Start () {

    //Debug.Log gets the value of any variable in our game.
    //We can change the value of the integer in this Debug (ex. Multiplying it by 2).
    //We can also re-assign that value.

    //So if you were to say:


    //myInt = 55;


    //Even though myInt was originally equal to 5, this would reassign that value to 55.


    //Debug.Log (myInt * 2);


    //To do something more detailed with the variables, we need to make a function (otherwise known as a method).
    //A function takes our variables and gives us other variables back. This is called a return.
    //Start is an example of a function that doesn't return anything so its type is void.

    //Here we are calling our new function.
    //FunctionName(data to send to parameters);
    //Instead of putting a new variable into the brackets, we will feed in something to be stored within number (from our MultiplyByTwo (int number) thing).
    //It will work in that because it is of the same type as the variable 'number'

    //MultiplyByTwo(myInt); //This is what it used to be before myInt was added in front of it.

    //myInt = MultiplyByTwo(myInt);
    //Debug.Log(myInt);

    //so myInt (a value of 5) is being fed into the machine.
    //This way ret - the new variable- is equal to myInt (which is 5) times 2. (ret = number * 2; down in the new function).
    //SO this MultiplyByTwo(myInt); currently represents 10 because I'm feeding in 5 and multiplying it by 2.

    //BUT until something is done with this information, no values have been changed.
    //ex) myInt hasn't been updated with the return value of this function
    //so what we can do is instead of saying MultiplyByTwo(myInt); we could say myInt = MultiplyByTwo(myInt);

    //and if we actually want to see that we can use Debug.Log(myInt); so it is printed in unity.

    //}

    //As its own function it is placed outside of the Start function.
    //type Function (type parameterName);
    //int is the type of the function, it is called MultiplyByTwo bcause that is what it will do.
    //Then we give it parameters. They type of info we want to feed this machine in order to get a result back from it in particular is an int.
    //There is a temporary variable in part of our machine called number. We will use that to be able to feed a number into the function when it is called upon.


    //int MultiplyByTwo(int number)
    //{
    //the curly braces open and close around the actios in our function.
    //int ret; //ret is short for return.
    //ret = number * 2; //ret is equal to the number times 2

    //return ret; //the actual result of running the function is that it outputs the value of ret.
    //Once we've done this, it needs to be called, so we are going to go back into the Start function.
    // }


    //VIDEO 2:

    //All functions must be defined with the instructions, and then they must be called.
    //if (Input.GetKeyUp ("space")) { } means that the code will wait for the player to press and let go of a button to go. In this case that button is the space bar.




}
