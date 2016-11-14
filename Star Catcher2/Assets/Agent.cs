using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour {

    private NavMeshAgent myAgent;
    public Transform player;

    public Animator myAnims;

	
	void Start () {
        myAgent = GetComponent<NavMeshAgent>();
	}
	
	
	void Update () {
        //look up how to do a jump in the animator bc I missed how to do it in class.
        //jump up and a jump down animation = then you get a hang time and the animation is dynamic.
        myAgent.destination = player.position;
        if (myAgent.isOnOffMeshLink)
        {
            myAnims.SetBool("jump", true);
        }
        //the transition out of jump.
        if (!myAgent.isOnOffMeshLink)
        {
            myAnims.SetBool("jump", false);
        }
    }
}
