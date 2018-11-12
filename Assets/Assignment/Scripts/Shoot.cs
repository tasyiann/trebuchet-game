using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Rigidbody Spoon;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Spoon.mass = 50;
            GameObject payload = GameObject.FindGameObjectWithTag("payload");
            if (payload)
            {
                payload.transform.SetParent(transform.parent);
                Destroy(payload, 10f);
            }
            
        }
    }
}
