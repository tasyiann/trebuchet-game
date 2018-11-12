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
		transform.Rotate(0f, speed * Input.GetAxis("Rotation")*Time.deltaTime, 0f);
        transform.Translate(speed * Input.GetAxis("Forward") * Time.deltaTime, speed * Input.GetAxis("UpDown") * Time.deltaTime, 0f);

    }
}
