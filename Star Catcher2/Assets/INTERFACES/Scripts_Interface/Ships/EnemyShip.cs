using UnityEngine;
using System.Collections;

public class EnemyShip : ShipBase {

	
	public override void Start () //so this will take everything in shipbase plus chase
    {
        base.Start();
        Chase();
	}

    private void Chase()
    {
        print("Chasing");
    }
	
}
