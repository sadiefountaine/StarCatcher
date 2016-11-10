using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour {

    public float endTime = 3;

    IEnumerator EndStar()
    {
        yield return new WaitForSeconds(endTime);
    }
    
	void OnCollisionEnter ()
    {
        Destroy(gameObject, endTime);
    }
}
//Add to star prefab
//make the spawn points a child of each level piece and then just put the spawn point above the camera (where you can't see it)
//Or you can make one spawn point, put it on the camera, raise it above the camera & then it spawns where you are. Put it slightly ahead of the camera.