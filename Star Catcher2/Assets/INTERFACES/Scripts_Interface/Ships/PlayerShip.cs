using UnityEngine;
using System.Collections;

public class PlayerShip : ShipBase {
    //because ShipBase is here then it will run the code from ShipBase because it is a child of ShipBase (even though there is no code in here for attack or destroy).
    public override void Start()
    {
        base.Start(); //we will call everything that is in the parent, plus we will Move it (below).
        Move();
    }

    void Move()
    {
        print("Moving with character controller");
    }

}
