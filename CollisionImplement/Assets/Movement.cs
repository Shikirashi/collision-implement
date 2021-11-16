using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{
	
	public float maxSpeed;

	GameObject player;
	Rigidbody rb;

    void Start(){
		player = gameObject;
		if(player.GetComponent<Rigidbody>() != null) {
			rb = player.GetComponent<Rigidbody>();
		}
		else {
			Debug.Log("Rigidbody is null");
		}
    }
	
    void Update(){
		if((Mathf.Abs(rb.velocity.magnitude) <= maxSpeed) && (Mathf.Abs(rb.velocity.y) < 1f)) {
			if (Input.GetKey(KeyCode.W)) {
				//move forward
				//Debug.Log("forward");
				rb.AddForce(player.transform.forward * 100f * Time.fixedDeltaTime, ForceMode.Force);
				Debug.Log("Speed is " + rb.velocity.magnitude);
			}
			if (Input.GetKey(KeyCode.A)) {
				//move left
				//Debug.Log("left");
				rb.AddForce(-player.transform.right * 100f * Time.fixedDeltaTime, ForceMode.Force);
				Debug.Log("Speed is " + rb.velocity.magnitude);
			}
			if (Input.GetKey(KeyCode.S)) {
				//move backward
				//Debug.Log("backward");
				rb.AddForce(-player.transform.forward * 100f * Time.fixedDeltaTime, ForceMode.Force);
				Debug.Log("Speed is " + rb.velocity.magnitude);
			}
			if (Input.GetKey(KeyCode.D)) {
				//move right
				//Debug.Log("right");
				rb.AddForce(player.transform.right * 100f * Time.fixedDeltaTime, ForceMode.Force);
				Debug.Log("Speed is " + rb.velocity.magnitude);
			}
		}
		else {
			Debug.Log("Moving at max speed");
		}
	}
}
