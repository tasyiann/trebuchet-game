using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody Spoon;
    public int weightOnSpoon = 50;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Spoon.mass = weightOnSpoon;
            GameObject[] payloads = GameObject.FindGameObjectsWithTag("payload");
            foreach (GameObject payload in payloads)
            {
                payload.transform.SetParent(transform.parent);
                Destroy(payload, 20f);
            }

        }
    }
}
