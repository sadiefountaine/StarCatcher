using UnityEngine;
using System.Collections;
using System;

public class Delegates : MonoBehaviour {

    Action <Delegates> Move;
    Action Idle;
    Action Jump;

    int speed = 200;

    void MoveHandler (Delegates obj)
    {
        print("Moving at " + obj.speed + " mph.");
        Move = null;
        Idle = IdleHandler;
    }

    void IdleHandler ()
    {
        print("Idling");
        Idle = null;
        Jump = JumpHandler;
    }

    void JumpHandler ()
    {
        print("Jumping");
        Jump = null;
    }

	// Use this for initialization
	void Start () {

        Move = MoveHandler;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Move != null)
            Move(this);
        if (Idle != null)
            Idle();
        if (Jump != null)
            Jump();
	}
}

//unity > learn > tutorials > topics > watch the animation videos. (To figure out how to best loop through your animations (jumping, running, and stopping).
//Hints **
// In Animator component> main body has animator on it. > Make script of if something is true or false etc.
//Right click > Make Transition in animator
//Script that accesses animation component and then change coroutine
// if running is true then it runs, if running is false then it doesn't run. Etc.