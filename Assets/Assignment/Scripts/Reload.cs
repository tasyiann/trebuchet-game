﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Rigidbody Spoon;
    public GameObject place;
    public GameObject projectile;
    private GameObject newProjectile;


    void Update()
    {

        if (Input.GetButton("Fire2"))
        {
            // Bring Trebuchet back to starting position.
            Spoon.mass = 500000;
        }
    }

    

    public void ReloadBall()
    {
        // Instatiate the payload.
        newProjectile = Instantiate(projectile, place.transform.position, place.transform.rotation) as GameObject;
        newProjectile.transform.parent = transform;
    }
}