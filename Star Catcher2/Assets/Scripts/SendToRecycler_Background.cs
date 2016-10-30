using UnityEngine;
//using System.Collections;
using System;

public class SendToRecycler_Background : MonoBehaviour
{

    public bool canRecycle;
    public static Action<SendToRecycler_Background> SendThis;

    void Start()
    {
        if (canRecycle)
            SendThis(this);
    }

    void OnTriggerEnter()
    {
        canRecycle = true;
        Start();
    }
}