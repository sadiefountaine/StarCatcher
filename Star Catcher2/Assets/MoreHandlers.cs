/*using UnityEngine;
using System.Collections;

public class MoreHandlers : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DelegatesIntro.EventString += ES;
        DelegatesIntro.myEvent += ME;
        DelegatesIntro.EventWithArgs += EA;
        DelegatesIntro.EventReturnArgs += ERA;
	}
	
    private string ES()
    {
        return "Dogs are better";
    }

    private string ME()
    {
        print("Cool beans");
    }

    private string EA(string obj)
    {
        print ("But I love " + obj);
    }

    private string ERA(string argl)
    {
        return "I love " + argl + "too";
    }
}
*/