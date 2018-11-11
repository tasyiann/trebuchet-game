using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, speed * Input.GetAxis("Horizontal")*Time.deltaTime, speed * Input.GetAxis("Vertical")*Time.deltaTime);
	}
}
