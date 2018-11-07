using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(new Vector3(0, 0, -1) * 100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<script2>().Jump();
        Destroy(collision.gameObject, 3.5f);
    }
}
