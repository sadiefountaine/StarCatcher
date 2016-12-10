using UnityEngine;
using System.Collections;

public class StarCollection : MonoBehaviour {

	
	void Start () {
	
	}
	
	
	void Update () {
	
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
           other.gameObject.SetActive(false);
        }
    }

}
