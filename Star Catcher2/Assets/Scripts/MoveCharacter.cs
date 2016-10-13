using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

    private CharacterController myCC;
    private Vector3 tempPos;
    public float speed = 1;
    public float graivty = 1;
    public float jumpSpeed = 1;

    public int jumpCount = 0;
    public int jumpCountMax = 2;

    //void StartGameHandler()
    //{
        //MoveUsingArrowKeys.MoveOnArrows += Move;
        //GameControl.StartGame -= StartGameHandler;
    //}
	// Use this for initialization
	void Start () {
        myCC = GetComponent<CharacterController>();
        //GameControl.StartGame += StartGameHandler;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax - 1)
        {
            jumpCount++;
            tempPos.y = jumpSpeed;
        }
    if (myCC.isGrounded)
        {
            jumpCount = 0;
        }
        tempPos.y -= graivty;
        tempPos.x = speed * Input.GetAxis("Horizontal");
        myCC.Move(tempPos * Time.deltaTime);
	}
}
