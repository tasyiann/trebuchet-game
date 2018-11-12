using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCounterWeight : MonoBehaviour {
    
    public Rigidbody rb;
    public float multiplier=2;
    public Text weightText;

	
	// Update is called once per frame
	void Update () {
        float verticalInput = Input.GetAxis("Weight");
        rb.mass += verticalInput * multiplier;
        weightText.text = "Counterweight: " + (int)rb.mass + " kg";
	}
}
