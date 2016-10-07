using UnityEngine;
using System.Collections;
using System;

public class UserInput : MonoBehaviour {

    public static Action<KeyCode> UserInput;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && UserInput != null)
        {
            UserInput(KeyCode.UpArrow);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && UserInput != null)
        {
            UserInput(KeyCode.DownArrow); //might need to be left and right arrow, not up and down.
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && UserInput != null)
        {
            UserInput(KeyCode.LeftArrow);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && UserInput != null)
        {
            UserInput(KeyCode.RightArrow);
        }

    }
}
