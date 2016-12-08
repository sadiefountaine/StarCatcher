using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillBunny : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StaticVars.nextSectionPosition = StaticVars.startPosition;
	}
	void OnTriggerEnter()
    {
        SceneManager.LoadScene (3);
    }
}
