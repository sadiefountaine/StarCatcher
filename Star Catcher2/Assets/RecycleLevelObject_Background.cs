using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLevelObject_Background: MonoBehaviour
{

    private Vector3 newLocation;
    public List<Recycler_Background> recyclableList;
    public int i = 0;

    void Start()
    {
        recyclableList = new List<Recycler_Background>();
        Recycler_Background.RecycleAction += RecycleActionHandler;
    }
    private void RecycleActionHandler(Recycler_Background _r)
    {
        recyclableList.Add(_r);
    }

    void OnTriggerEnter()
    {
        i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
        newLocation.y = 93;
        newLocation.z = 40;
        newLocation.x = StaticVars_Background.nextSectionPosition;
        recyclableList[i].mesh.position = newLocation;
        StaticVars_Background.nextSectionPosition += StaticVars_Background.distance;
        if (recyclableList.Count > 0)
            recyclableList.RemoveAt(i);
    }

}
