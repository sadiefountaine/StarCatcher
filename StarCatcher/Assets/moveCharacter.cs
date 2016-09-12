using UnityEngine;
using System.Collections;

public class moveCharacter : MonoBehaviour {

    //Character controller component with a move method (private) - identifyer is myCC
    private CharacterController myCC;
    //Temp var of datatype vector3 to move the character (TempPos = temporary position)
    private Vector3 tempPos;
    //Speed of the temp var in x. speed is 10.
    public float speed = 1;
    //gravity, negative so it falls. Positive makes it float up.
    public float gravity = 1;
    //jump
    public float jumpSpeed = 1;

    //public int jumpCountBase = 2; (to do a power-up jump)

    public int jumpCount = 0;
    public int jumpCountMax = 2;

	// Use this for initialization
	void Start () {
       
        //This finds the character component
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //jump listens for input which is space, so when you press space you get a jump
        //waiting for input and comparing jumpCount
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax-1)
            //jumpCountMax-1 makes it so there are only two jumps, not three. There were three jumps because it counts 0, 1, 2 making 3 jumps.
        {
            jumpCount++;
            //incrementing jumpCount by 1

            //to verify it works
            //print("Jump");

            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }
        //test if the character controller is grounded
        if (myCC.isGrounded)
        {
            //reset the jump count if grounded.
            jumpCount = 0;
            //So the minute we touch the ground again, we can double jump again.
        }

        //&& my.CC isGrounded

        //if(jumpCount > 1)
        //tempPos.y = jumpSpeed;
        //jumpCount++;

        //gravity , -= takes the value of gravity and subtracts from it thus easing us up and down at a rate of three in this case
        //adding gravity var to the y position of the tempPos var
        tempPos.y -= gravity;

        //Now player moves with the arrow keys left & right. (0 no input, -1 left , 1 right)
        //adding speed var to the tempPos var x value with the right and left arrow keys
        tempPos.x = speed * Input.GetAxis("Horizontal");
        
        //Time.delta time slows it down to a managable/consistent rate based on your frame rate. This moves consistently. Memorize this.
        //Moves the character controller at an even pace (deltaTime)
        myCC.Move(tempPos * Time.deltaTime);
	}
}
