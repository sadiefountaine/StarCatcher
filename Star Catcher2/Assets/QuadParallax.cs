using UnityEngine;
using System.Collections;

public class QuadParallax : MonoBehaviour {

    public float speed = 0.01f;
	
	void Start () {
	
	}
	
	
	void Update ()
    {
        Vector2 offset = new Vector2(speed * Time.time, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
