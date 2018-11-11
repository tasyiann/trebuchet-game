using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Rigidbody myRigidbody;
    public float fireDelta = 0.5F;
    private float nextFire = 0.5F;
    private float myTime = 0.0F;

    void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            nextFire = myTime + fireDelta;
            myRigidbody.constraints = RigidbodyConstraints.None;
            

            nextFire = nextFire - myTime;
            myTime = 0.0F;
        }
    }
}
