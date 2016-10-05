using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

    public Transform characterArt;
    public bool forward = true;

    void FlipCharacter (bool _b)
    {
        characterArt.Rotate(0, 180, 0);
        //print("forward");
        forward = _b;
    }
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow) && forward) //or maybe UpArrow ???
        {
            FlipCharacter(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && !forward) //or maybe DownArrow ???
        {
            FlipCharacter(true);
        }

    }
}
