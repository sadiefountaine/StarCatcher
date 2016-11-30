using UnityEngine;
//using System.Collections;\
using System;

public class DelegatesIntro : MonoBehaviour {

    //public delegate void myDelegate(); (deleted this line to make it shorter)
    //events call delegates saftely
    public static Action myEvent; //deleted myDelegate and replaced it with Action.
    
    
    //an Action is a delegate and an event in one.


    //now it is shorter and still works :)

    //public delegate void DelWithArgs(string s); //no return, passing a string, s is variable name, datatype is string //deleted this delegate
    public static Action<string> EventWithArgs; //subscribe to event //deleted DelWithArgs and replaced it with Action<string>


    //public delegate string DelString(); //get data back,  not going to pass any arguments, deleted this
    public static Func<string> EventString; //func is a delegate with a return type.


    //public delegate string DelReturnArgs(string s);
    public static Func<string, string> EventReturnArgs;


    void Start()
    {
        string data = EventReturnArgs("Cats!!!");
        print(data);

        print (EventString()); //calling it a bit differently. Will only say "I hate Cats." one time. - only calling once, but you'll only see the last one even though it runs 3 times.

        EventWithArgs("Hello World"); //call event

        if (myEvent != null)
            myEvent();
    }
}
