using UnityEngine;
using System.Collections;

public class CharacterFlip : MonoBehaviour
{

    public Transform characterArt;
    public bool forward = true;

    void FlipCharacter(KeyCode _keyCode)
    {
        switch (_keyCode)
        {
            case KeyCode.UpArrow: //or left or right arrows
                if (forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = false;
                }
                break;

            case KeyCode.DownArrow: //or left/right arrow
                if (!forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = true;
                }
                break;
        }

        
        //print("forward");
        //forward = _b;
    }

    void Start()
    {
        UserInputScript.UserInput += FlipCharacter;
    }
    void OnDestroy()
    {
        UserInputScript.UserInput -= FlipCharacter;
    }
}
