using UnityEngine;
using System.Collections;
using System;

public class StarSpawner : MonoBehaviour {

    public static Action<Transform> SendSpawner; //upper-case T is a class

	
	void Start ()
    {
        if(SendSpawner != null)
            SendSpawner(transform); //lower-case t is an instance
        
	}
}
