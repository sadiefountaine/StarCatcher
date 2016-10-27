using UnityEngine;
using System.Collections;

public class CloneStar : MonoBehaviour {

    public Transform[] spawnPoints;
    public Transform star;
    public float spawnFrequency = 1;
    //just spawns until we tell it to stop
    public bool canSpawnStars = true;

    private int i = 0;

	IEnumerator SpawnStars()
    {
        //just spawns until we tell it to stop
        while (canSpawnStars)
        {
            //just spawns until we tell it to stop
            i = Random.Range(0, spawnPoints.Length - 1);
            //print(spawnPoints.Length);
            Instantiate(star, spawnPoints[i].position, Quaternion.identity); //Quaternion.identity means reset rotate values to zero on star's rotation.
            yield return new WaitForSeconds(spawnFrequency);
            //i++;
        }
        //return null;
    }

	void Start () {
        StartCoroutine(SpawnStars());
	}
}
