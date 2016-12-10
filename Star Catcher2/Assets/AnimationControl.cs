using UnityEngine;
using System.Collections;

public class AnimationControl : MonoBehaviour {

    Animator anim;
    int jumpHash = Animator.StringToHash("PlayerJump");

    int runHash = Animator.StringToHash("PlayerRun");


	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(jumpHash);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetTrigger(runHash);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetTrigger(runHash);
        }
	}
}
