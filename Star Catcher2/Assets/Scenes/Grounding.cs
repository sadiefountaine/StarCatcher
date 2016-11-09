using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class Grounding : MonoBehaviour {

    public Vector3 startPoint;
    private CharacterController cc;
    public float gravity = 1;
    public float speed = 1;
    private Vector3 tempP;

	// Use this for initialization
	void Start () {
        startPoint = transform.position;
        cc = GetComponent<CharacterController>();
	}

    void OnTriggerEnter()
    {
        //if(cc.velocity.x <= 40)
        //gravity *= 1.5f;
        speed *= -1;
        //transform.position = startPoint;
    }

	// Update is called once per frame
	void Update () {
        print(cc.velocity);
        tempP.y = gravity;
        // -= constantly adds and equals and we don't want that, so we do = -gravity
        cc.Move(tempP * Time.deltaTime);
        if (cc.isGrounded)
        {
            tempP.x = speed;
        }
        else
        {
            tempP.x = 0;
        }
	}
}

//if you add this script to the cube then it makes a character controller because of the Required Component