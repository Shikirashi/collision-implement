using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour{

	public Material redMat;
	public Material greenMat;
	public GameObject gate;

	Renderer renderer;
	BoxCollider collider;
	bool isActive;

    void Start(){
		renderer = GetComponent<Renderer>();
		renderer.material = redMat;
		collider = GetComponent<BoxCollider>();
		isActive = false;
    }

	private void Update() {
		if (isActive) {
			if(gate.transform.position.y >= -1) {
				gate.transform.Translate(-Vector3.up * 1f * Time.deltaTime);
			}
		}
		else {
			if (gate.transform.position.y < .5f) {
				gate.transform.Translate(Vector3.up * 1f * Time.deltaTime);
			}
		}
	}

	private void OnTriggerEnter(Collider other) {
		if(other.tag == "Weight") {
			renderer.material = greenMat;
			isActive = true;
		}
	}

	private void OnTriggerExit(Collider other) {
		if (other.tag == "Weight") {
			renderer.material = redMat;
			isActive = false;
		}
	}
}
