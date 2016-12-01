/*using UnityEngine;
using System.Collections;

public class EventHandlerIntro : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //calling the event
        DelegatesIntro.myEvent += MyEventHandler;

        DelegatesIntro.EventWithArgs += EventWithArgsHandler;

        DelegatesIntro.EventString += EventStringHandler;

        DelegatesIntro.EventReturnArgs += EventReturnArgsHandler;
	}

    private void EventReturnArgsHandler(string s)
    {
        return "The animals I hate most are + s";
    }

    private void EventStringHandler(string s)
    {
        print("Do you like cats?"); //will run this 3 times.
        return "I hate Cats."; //getting data back, will run this 3 times but only display once.
    }

    private void EventWithArgsHandler(string s)
    {
        print(s); //now we have an event with an argument.
    }

    private void MyEventHandler()
    {
        print("Ran");
    }

}
*/