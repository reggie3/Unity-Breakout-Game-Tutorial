using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float ballInitialVelocity = 600;

    private Rigidbody rb;
    private bool ballInPlay = false;

	void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if ((Input.GetButtonDown("Fire1")) && (!ballInPlay))
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
        }
	}
}
