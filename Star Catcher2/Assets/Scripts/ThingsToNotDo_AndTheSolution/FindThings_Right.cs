using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindThings_Right : MonoBehaviour {

    public List<GameObject> level;
    
    void AddToList (GameObject _go)
    {
        level.Add(_go);
    }

    
    void Start()
    {
        SendThis_Right.SendThis += AddToList;
    }
}

//every object that has this script will be added to the list. (Add the land to the script and the capsule)
//Okay, so it did find one.
//SendThisRight > Execution Order > FindThings_Right should be first, and SendThings_Right should be second
//It gives you the objects you want, and only the objects you want. It wont continue to find everything so your game wont run slow with this. It will run slow with your FindThings_Wrong script.
//You can have levels with power-ups and other levels with no power-ups and you won't have to go around removing scripts and changing your game. You can just use this and if your objects are there it will run, if they aren't it wont run.
//This doesn't have to run.