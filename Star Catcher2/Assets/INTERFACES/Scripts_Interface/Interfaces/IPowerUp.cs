using UnityEngine;
using System.Collections;

public interface IPowerUp { //doesn't extend monodeveolop, not a class but an interfaces, and names start with I.

    int power { get; set; } //this is a variable but its a property //get means i can get info about the power. //set means I can set the power. //If i leave off set then i can't set the power //if i leave of get then i can't get the power.

    void Start(); //not declaring what start is, but saying start is required

    void OnTriggerEnter(); //if im using the interface of power up every interface using powerup is going to require ontriggerenter no matter what.


    //because it doesn't contain monodevelop, start and update no longer work inside it.

    //Now we are going to implement this in HealthPowerUp.

}
