using UnityEngine;
using System.Collections;
using System;

public class Recycler_Background : MonoBehaviour
{

    public static Action<Recycler_Background> RecycleAction;
    public bool canBeRecycled = false;
    public Transform mesh;

    // Use this for initialization
    void Start()
    {
        mesh = this.GetComponent<Transform>();
        if (RecycleAction != null && canBeRecycled)
            RecycleAction(this);
    }
    void OnTriggerEnter()
    {
        canBeRecycled = true;
        Start();
    }
}
