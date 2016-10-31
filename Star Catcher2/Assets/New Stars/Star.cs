using UnityEngine;
using System.Collections;
using System;

public class Star : MonoBehaviour {

    public static Action<Transform> SendStar;

	// Use this for initialization
	void Start ()
    {
        //because we removed our mesh renderer on the stars so you can't see them all fall at once when you hit play.
        GetComponent<MeshRenderer>().enabled = false;
        if (SendStar != null)
            SendStar(transform);
	}


}
