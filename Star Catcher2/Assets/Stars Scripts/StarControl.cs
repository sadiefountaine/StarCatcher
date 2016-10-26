using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour {

    public int forceTime = 10;

    public float forceDuration = 0.1f;
    //private bool canAddForce = true;
    private Rigidbody rigid;
    private float force;
    private Vector3 forceVector;
    public float forceRange = 10;
    //private Vector3 torqueVector;

    private float torque;
    public float torqueRange = 2;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
	
	IEnumerator RunRandomForce()
    {
        force = Random.Range(-forceRange, forceRange);
        torque = Random.Range(-torqueRange, torqueRange); //he moved these two down into the while thing.
        //while (canAddForce)
        while (forceTime > 0)
        {
            yield return new WaitForSeconds(forceDuration);
            forceVector.x = force;
            torqueVector.z -= force/force;
            rigid.AddTorque(torqueVector);
            rigid.AddForce(forceVector);

            forceTime--;
        }
    }

    public float endTime = 3;

    void OnCollisionEnter ()
    {
        //canAddForce = false;
        Destroy(gameObject, endTime);
    }
	
}
