using UnityEngine;
using System.Collections;

public class CharacterSlide : MonoBehaviour {

    private CharacterController myCC;
    public int slideDuration = 20;
    public float slideTime = 0.01f;

    //Code routine are IEnumerators
    IEnumerator Slide ()
    {
        int i = 0;

        while (i < slideDuration)
        {
            i++;
            //Add one to i. To incrament it.

            yield return new WaitForSeconds(slideTime);
            print("sliding");

        }
        //While iteratiions
        //Wait for seconds
        //Move the character controller
    }

	// Use this for initialization
	void Start ()
    {
        myCC = GetComponent<CharacterController>();
        StartCoroutine(Slide());
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
