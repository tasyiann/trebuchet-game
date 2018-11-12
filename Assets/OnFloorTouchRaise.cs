using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnFloorTouchRaise : MonoBehaviour {
    public GameEvent eventToTrigger;
    private bool alreadyEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(!alreadyEntered)
        {
            eventToTrigger.Raise();
            alreadyEntered = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        alreadyEntered = false;
    }


}
