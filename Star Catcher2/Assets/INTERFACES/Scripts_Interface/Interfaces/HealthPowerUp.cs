using UnityEngine;
using System.Collections;

public class HealthPowerUp : MonoBehaviour, IPowerUp {

    public int power
    {
        get
        {
            throw new NotImplementedException();
        }
    }
	
	public void OnTriggerEnter ()
    {
        print("Enter"); //what you do inside can be different per power up.
	}

    public void Start ()
    {
	
	}
}

//Unity3d > Learn > scripting > interfaces