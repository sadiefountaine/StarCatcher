using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour
{

    public Transform characterArt;
    public bool forward = true;

    void FlipCharacter(KeyCode _keyCode)
    {
        switch (_keyCode)
        {
            case KeyCode.UpArrow: //or left or right arrows
                print("up");
                break;
        }

        characterArt.Rotate(0, 180, 0);
        //print("forward");
        //forward = _b;
    }

    void Start()
    {
        UserInput.UserInput += FlipCharacter;
    }
}
