using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	
	void Start () {
        StaticVars.score = PlayerPrefs.GetInt("Score", 0);
        StartCoroutine(AddToScore());
	}
	IEnumerator AddToScore()
    {
        StaticVars.score++;
        yield return new WaitForSeconds(1);
        print(StaticVars.score);
        StartCoroutine(AddToScore());
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", StaticVars.score);
        print("Final Score: " + PlayerPrefs.GetInt("Score"));
        print("Game Over");
    }
}

//How to save game scores