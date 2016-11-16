using UnityEngine;
using System.Collections;

public class ShipBase : MonoBehaviour, IDamage, IAttack {

    public virtual void Attack() 
    {
        print("Attacking");
    }
    public void Damage()
    {
        
    }

    

	// Use this for initialization
	public virtual void Start () //virtual means we can override this in a child class. Protected means its visible to its children, but not to other scripts.
    {
        print("Refuel"); //now all the ships can refule
        Attack();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
