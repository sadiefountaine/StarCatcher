using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

    CharacterController myCC;
    Vector3 tempPos;
    public float gravity = 1;

    public float sideForce = 1;

	// Use this for initialization
	void Start () {
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tempPos.y -= gravity*Time.deltaTime;

        tempPos.z = sideForce;

        if (myCC.isGrounded)
        {
            tempPos.y = 0;
        }

        print(myCC.velocity);
        myCC.Move(tempPos);
	}
}

//now gravity isn't increasing every time you jump. So... fix the gravity on your move character.
//You will have to change your jump speed now.

    //How to make the character not move on the z.
    //It needs a force on it.
    //Put a box collider along each piece of land so it is forced to go along the wall.
    //You can also child the barrier (box collider) to the camera.
    //With the side force code the character will constantly be pushing against the barrier so it can't go around land stuff because the force is stopping it.